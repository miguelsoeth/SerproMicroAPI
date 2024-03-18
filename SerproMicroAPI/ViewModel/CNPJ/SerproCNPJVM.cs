using System.Collections.Generic;


namespace SerproMicroAPI.ViewModel.CNPJ
{

    public class SerproCNPJVM
    {
        public string ni { get; set; }
        public string tipoEstabelecimento { get; set; }
        public string nomeEmpresarial { get; set; }
        public string nomeFantasia { get; set; }
        public SituacaoCadastralSerpro situacaoCadastral { get; set; }
        public NaturezaJuridicaSerpro naturezaJuridica { get; set; }
        public CnaePrincipalSerpro cnaePrincipal { get; set; }
        public List<CnaeSecundaria> cnaeSecundarias { get; set; }
        public EnderecoSerpro endereco { get; set; }
        public MunicipioJurisdicaoSerpro municipioJurisdicao { get; set; }
        public List<Telefone> telefones { get; set; }
        public string correioEletronico { get; set; }
        public string capitalSocial { get; set; }
        public string dataAbertura { get; set; }
        public string porte { get; set; }
        public string situacaoEspecial { get; set; }
        public string dataSituacaoEspecial { get; set; }

        public class CnaePrincipalSerpro
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class CnaeSecundaria
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class EnderecoSerpro
        {
            public string TipoLogradouro { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Cep { get; set; }
            public string Bairro { get; set; }
            public Municipio Municipio { get; set; }
            public string Uf { get; set; }
            public Pais Pais { get; set; }
        }

        public class Municipio
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class MunicipioJurisdicaoSerpro
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class NaturezaJuridicaSerpro
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class Pais
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public class SituacaoCadastralSerpro
        {
            public string Codigo { get; set; }
            public string Data { get; set; }
            public string Motivo { get; set; }
        }

        public class Telefone
        {
            public string Ddd { get; set; }
            public string Numero { get; set; }
        }
    }


}
