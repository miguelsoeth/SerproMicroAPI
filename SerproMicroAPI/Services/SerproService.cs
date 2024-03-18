using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;
using SerproMicroAPI.ViewModel.CNPJ;
using SerproMicroAPI.ViewModel.DividaAtiva;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SerproMicroAPI.Services
{
    public interface ISerproService
    {
        public Task<HttpResponseMessage> ConsultaGet(string key, string documento, string url);
        public Task<HttpResponseMessage> ConsultaPost(string key, string documento, string url, string requestBody);
    }
    public class SerproService : ISerproService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SerproService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<HttpResponseMessage> ConsultaGet(string key, string documento, string url)
        {            
            var client = _httpClientFactory.CreateClient();
            client.Timeout = new TimeSpan(0, 1, 260);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
            string urlCompleta = $"{url}{documento}";
            //CONSULTA
            Console.WriteLine($"Consulta Serpro - {urlCompleta}");
            var retorno = await client.GetAsync(urlCompleta);
            if (!retorno.IsSuccessStatusCode)
            {
                Console.WriteLine($"Erro ao consultar Serpro - {documento} {retorno.StatusCode} {retorno.ReasonPhrase}");
            }
            return retorno;
        }

        public async Task<HttpResponseMessage> ConsultaPost(string key, string documento, string url, string requestBody)
        {
            var client = _httpClientFactory.CreateClient();
            client.Timeout = new TimeSpan(0, 1, 260);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", key);
            StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            Console.WriteLine($"Consulta Serpro - {url} | {requestBody}");
            var retorno = await client.PostAsync(url, content);
            if (!retorno.IsSuccessStatusCode)
            {
                Console.WriteLine($"Erro ao consultar Serpro - {documento} {retorno.StatusCode} {retorno.ReasonPhrase}");
            }
            return retorno;
        }
    }
}
