using SerproMicroAPI.ViewModel;
using SerproMicroAPI.ViewModel.CND;
using SerproMicroAPI.ViewModel.CNPJ;
using SerproMicroAPI.ViewModel.CPF;
using SerproMicroAPI.ViewModel.DividaAtiva;
using SerproMicroAPI.ViewModel.Mix;

namespace SerproMicroAPI.Transform
{
    public class TransformSerpro
    {
        public static DepsMixSerproCPFVM CPF(SerproCPFVM serproVM)
        {
            var pessoa = new DepsMixSerproCPFVM();

            pessoa.Nome = serproVM.Nome;
            pessoa.Cpf = serproVM.Ni;

            DateTime dateOfBirth = DateTime.ParseExact(serproVM.Nascimento, "ddMMyyyy", null);
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - dateOfBirth.Year;
            if (currentDate.Month < dateOfBirth.Month || currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day)
            {
                age--;
            }
            pessoa.DataNascimento = $"{dateOfBirth.ToShortDateString()}";
            pessoa.Idade = age.ToString();

            pessoa.SituacaoCadastral = $"{serproVM.Situacao.Descricao}";
            if (serproVM.Obito != null)
            {
                if (pessoa.Obito == null)
                {
                    pessoa.Obito = new DepsMixCredilinkObitoVM();
                }
                pessoa.Obito.Obito = serproVM.Obito;
            }
            pessoa.Message = serproVM.Situacao.Descricao;

            return pessoa;
        }

        public static DepsMixSerproCNPJVM CNPJ (SerproCNPJVM serproVM)
        {
            var serproPjVM = serproVM;
            var cnaePrincipal = serproPjVM?.naturezaJuridica;
            var Empresa = new DepsMixSerproCNPJVM();
            Empresa.Success = true;
            Empresa.SituacaoCadastral = serproPjVM?.situacaoEspecial ?? Empresa.SituacaoCadastral;
            Empresa.Cnpj = serproPjVM?.ni ?? Empresa.Cnpj;
            Empresa.TipoUnidade = serproPjVM?.tipoEstabelecimento ?? Empresa.TipoUnidade;
            Empresa.RazaoSocial = serproPjVM?.capitalSocial ?? Empresa.RazaoSocial;
            Empresa.NomeFantasia = serproPjVM?.nomeFantasia ?? Empresa.NomeFantasia;
            Empresa.DataInicioAtividade = serproPjVM?.dataAbertura ?? Empresa.DataInicioAtividade;
            Empresa.Endereco = serproPjVM?.endereco.Logradouro ?? Empresa.Endereco;
            Empresa.Numero = serproPjVM?.endereco.Numero ?? Empresa.Numero;
            Empresa.Bairro = serproPjVM?.endereco.Bairro ?? Empresa.Bairro;
            Empresa.Complemento = serproPjVM?.endereco.Complemento ?? Empresa.Complemento;
            Empresa.Cep = serproPjVM?.endereco.Cep ?? Empresa.Cep;
            Empresa.Uf = serproPjVM?.endereco.Uf ?? Empresa.Uf;
            Empresa.Municipio = serproPjVM?.endereco.Municipio.Descricao ?? Empresa.Municipio;
            Empresa.Porte = serproPjVM?.porte ?? Empresa.Porte;
            Empresa.NaturezaJuridica = serproPjVM?.naturezaJuridica.Descricao ?? Empresa.NaturezaJuridica;
            Empresa.CnaePrincipal = serproPjVM?.cnaePrincipal.Descricao != null ? $"{cnaePrincipal?.Codigo} - {cnaePrincipal?.Descricao}" : Empresa.CnaePrincipal;
            Empresa.CapitalSocialEmpresa = serproPjVM.capitalSocial ?? Empresa.CapitalSocialEmpresa;
            Empresa.SituacaoEspecial = serproPjVM.situacaoEspecial;
            Empresa.DataSituacaoEspecial = serproPjVM.dataSituacaoEspecial;

            var temCnaes = serproPjVM?.situacaoCadastral.Motivo;
            if (temCnaes != null)
            {
                if (Empresa.CnaesSecundarios != null && Empresa.CnaesSecundarios.Any())
                {
                    Console.WriteLine($"{Empresa.Cnpj}. Possui cnaes secundários credilink, mas não possui na ReceitaWs.");
                }
            }

            return Empresa;

        }

        public static DepsMixSerproCNDVM CND (SerproCNDVM serproVM)
        {
            var cnd = new DepsMixSerproCNDVM();

            var Empresa = new DepsMixSerproCNPJVM();
            Empresa.Cnpj = serproVM.Certidao.ContribuinteCertidao;

            cnd.certidao = serproVM;
            cnd.empresa = Empresa;

            return cnd;
        }
        public static DepsMixSerproDividaAtivaVM DividaAtiva(SerproDividaAtivaVM serproVM)
        {
            var dividaAtiva = new DepsMixSerproDividaAtivaVM();

            var Empresa = new DepsMixSerproCNPJVM();
            Empresa.Success = true;
            Empresa.Cnpj = serproVM.Devedor[0].CpfCnpj;
            Empresa.NomeFantasia = serproVM.Devedor[0].NomeDevedor;

            dividaAtiva.dividaAtiva = serproVM;
            dividaAtiva.empresa = Empresa;

            return dividaAtiva;
        }

    }
}
