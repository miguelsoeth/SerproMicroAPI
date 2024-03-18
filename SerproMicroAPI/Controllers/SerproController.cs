using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SerproMicroAPI.Services;
using SerproMicroAPI.Transform;
using SerproMicroAPI.ViewModel;
using SerproMicroAPI.ViewModel.CND;
using SerproMicroAPI.ViewModel.CNPJ;
using SerproMicroAPI.ViewModel.CPF;
using SerproMicroAPI.ViewModel.DividaAtiva;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SerproMicroAPI.Controllers
{
    [ApiController]
    [Route("api/serpro")]
    public class SerproController : ControllerBase
    {
        private readonly ISerproService _serproService;
        private readonly string key = "06aef429-a981-3ec5-a1f8-71d38d86481e";
        private readonly string urlCPF = "https://gateway.apiserpro.serpro.gov.br/consulta-cpf-df-trial/v1/cpf/";
        private readonly string urlCNPJ = "https://gateway.apiserpro.serpro.gov.br/consulta-cnpj-df-trial/v2/basica/";
        private readonly string urlCND = "https://gateway.apiserpro.serpro.gov.br/consulta-cnd-trial/v1/certidao";
        private readonly string urlInscricao = "https://gateway.apiserpro.serpro.gov.br/consulta-divida-ativa-df-trial/api/v1/inscricao/";
        private readonly string urlDevedor = "https://gateway.apiserpro.serpro.gov.br/consulta-divida-ativa-df-trial/api/v1/devedor/";
        public SerproController(ISerproService serproService)
        {
           _serproService = serproService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(SerproVM), StatusCodes.Status200OK)]
        public async Task<IActionResult> Consultar([FromQuery][Required] string doc, [FromQuery][Required] string type)
        {
            var serproVM = new SerproVM();
            HttpResponseMessage response = new HttpResponseMessage();

            if (type == "SERPRO_CONSULTA_CPF")
            {
                try
                {
                    response = await _serproService.ConsultaGet(key, doc, urlCPF);
                    if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<SerproCPFVM>(content);
                    if (obj != null)
                    {
                        var cpf = TransformSerpro.CPF(obj);
                        serproVM.cpf = cpf;
                    }
                }
                catch (Exception ex)
                {
                    serproVM.Messagem = ex.Message;
                }
                
            }
            else if (type == "SERPRO_CONSULTA_CNPJ")
            {
                try
                {
                    response = await _serproService.ConsultaGet(key, doc, urlCNPJ);
                    if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<SerproCNPJVM>(content);
                    if (obj != null)
                    {
                        var cnpj = TransformSerpro.CNPJ(obj);
                        serproVM.cnpj = cnpj;
                    }
                }
                catch (Exception ex)
                {
                    serproVM.Messagem = ex.Message;
                }                
            }
            else if (type == "SERPRO_CONSULTA_CND")
            {
                try
                {
                    int codPessoa = doc.Length == 11 ? 2 : 1;
                    string requestBody = $"{{\"TipoContribuinte\":{codPessoa},\"ContribuinteConsulta\":\"{doc}\",\"CodigoIdentificacao\":900{codPessoa},\"GerarCertidaoPdf\":false}}";
                    response = await _serproService.ConsultaPost(key, doc, urlCND, requestBody);
                    if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);

                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<SerproCNDVM>(content);
                    if (obj != null)
                    {
                        var cnd = TransformSerpro.CND(obj);
                        serproVM.cnd = cnd;
                    }
                }
                catch (Exception ex)
                {
                    serproVM.Messagem = ex.Message;
                }
                
            }
            else if (type == "SERPRO_CONSULTA_DIVIDA_ATIVA")
            {
                try
                {
                    string content = "";
                    response = await _serproService.ConsultaGet(key, doc, urlDevedor);
                    if (!response.IsSuccessStatusCode) throw new Exception($"Erro ao pesquisar devedor: {response.ReasonPhrase}");
                    content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                    var devedor = JsonConvert.DeserializeObject<List<SerproDevedorVM>>(content);
                    await Task.Delay(TimeSpan.FromSeconds(4)); //DELAY NECESSÁRIO POR SER AMBIENTE TRIAL
                    //TRIAL
                    devedor[0].NumeroInscricao = "4483300091135";

                    response = await _serproService.ConsultaGet(key, devedor[0].NumeroInscricao, urlInscricao);
                    if (!response.IsSuccessStatusCode) throw new Exception($"Erro ao pesquisar inscrição: {response.ReasonPhrase}");
                    content = await response.Content.ReadAsStringAsync();
                    var inscricao = JsonConvert.DeserializeObject<List<SerproInscricaoVM>>(content);

                    var dividaAtiva = new SerproDividaAtivaVM();
                    if (devedor != null)
                    {
                        dividaAtiva.Devedor = devedor;
                    }
                    if (inscricao != null)
                    {
                        dividaAtiva.Inscricao = inscricao;
                    }

                    serproVM.dividaAtiva = TransformSerpro.DividaAtiva(dividaAtiva);
                }
                catch (Exception ex)
                {
                    serproVM.Messagem = ex.Message;
                }
                
            }
            else
            {
                serproVM.Messagem = "Tipo não encontrado";
                response.StatusCode = HttpStatusCode.NotFound;
            }

            serproVM.Status = response.StatusCode;

            return Ok(serproVM);
        }
    }
}
