namespace SerproMicroAPI.ViewModel.Mix
{
    //DepsMixCredilinkInformacaoCadastralPJVM
    public class DepsMixSerproCNPJVM
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public string Cnpj { get; set; }
        public string TipoUnidade { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string DataSituacaoCadastral { get; set; }
        public string DataInicioAtividade { get; set; } // data fundação DataInicioAtividade
        public string DataInicioAtividadeMatriz { get; set; }
        public string MotivoSituacaoCadastral { get; set; }
        public string NaturezaJuridica { get; set; }
        public string CnaePrincipal { get; set; }
        public List<string> CnaesSecundarios { get; set; } = new List<string>();
        public string Endereco { get; set; } // endereço DescricaoTipoLogradouro +  Logradouro
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; } // cidade
        public string MunicipioCodigoIbge { get; set; }
        public string QualificacaoResponsavel { get; set; }
        public string CapitalSocialEmpresa { get; set; }
        public string FaturamentoPresumido { get; set; }
        public string Porte { get; set; }
        public string QuantidadeFuncionarios { get; set; }
        public string OpcaoPeloSimples { get; set; }
        public string DataOpcaoPeloSimples { get; set; }
        public string DataExclusaoOpcaoPeloSimples { get; set; }
        public string OpcaoMei { get; set; }
        public string SituacaoEspecial { get; set; }
        public string DataSituacaoEspecial { get; set; }
        public string NomeEnteFederativo { get; set; }
        public string QuantidadeFiliais { get; set; }
        public string PossuiRestricao { get; set; }
        public string Nire { get; set; }
        public bool OtimizaSemInformacao { get; set; }
        public string Erro { get; set; }
        public string DataHoraReceita { get; set; }
        public List<DepsMixCredilinkFiliaisPorSituacaoVM> FiliaisPorSituacao { get; set; }
        public List<DepsMixCredilinkFiliaisPorCnaeVM> FiliaisPorCnae { get; set; }
        //public List<DepsMixCredilinkQuadroSocietarioVM> QuadroSocietario { get; set; }// pj
        public bool IsInformacaoTagReceitaAtualizada { get; set; }
        public string CnpjMatriz { get; set; }
    }

    public class DepsMixCredilinkFiliaisPorSituacaoVM
    {
        public int QuantidadeFiliais { get; set; }
        public string Situacao { get; set; }
    }

    public class DepsMixCredilinkFiliaisPorCnaeVM
    {
        public int QuantidadeFiliais { get; set; }
        public string Cnae { get; set; }
    }

}
