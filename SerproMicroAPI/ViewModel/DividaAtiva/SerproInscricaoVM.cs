using System.Text.Json.Serialization;

namespace SerproMicroAPI.ViewModel.DividaAtiva
{
    public class SerproInscricaoVM
    {
        [JsonPropertyName("inscricao")]
        public string Inscricao { get; set; }

        [JsonPropertyName("processoAdministrativo")]
        public string ProcessoAdministrativo { get; set; }

        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("dataInscricao")]
        public string DataInscricao { get; set; }

        [JsonPropertyName("numeroPFNResponsavel")]
        public string NumeroPFNResponsavel { get; set; }

        [JsonPropertyName("nomePFNResponsavel")]
        public string NomePFNResponsavel { get; set; }

        [JsonPropertyName("numeroPFNInscricao")]
        public string NumeroPFNInscricao { get; set; }

        [JsonPropertyName("nomePFNInscricao")]
        public string NomePFNInscricao { get; set; }

        [JsonPropertyName("numeroProcessoJudicial")]
        public string NumeroProcessoJudicial { get; set; }

        [JsonPropertyName("numeroProcessoJudicialNovo")]
        public string NumeroProcessoJudicialNovo { get; set; }

        [JsonPropertyName("orgaoOrigem")]
        public string OrgaoOrigem { get; set; }

        [JsonPropertyName("codigoNaturezaReceita")]
        public string CodigoNaturezaReceita { get; set; }

        [JsonPropertyName("nomeNaturezaReceita")]
        public string NomeNaturezaReceita { get; set; }

        [JsonPropertyName("codigoReceitaPrincipal")]
        public string CodigoReceitaPrincipal { get; set; }

        [JsonPropertyName("nomeReceita")]
        public string NomeReceita { get; set; }

        [JsonPropertyName("codigoSerie")]
        public string CodigoSerie { get; set; }

        [JsonPropertyName("nomeSerie")]
        public string NomeSerie { get; set; }

        [JsonPropertyName("codigoOrgaoJustica")]
        public string CodigoOrgaoJustica { get; set; }

        [JsonPropertyName("nomeOrgaoJustica")]
        public string NomeOrgaoJustica { get; set; }

        [JsonPropertyName("numeroJuizo")]
        public string NumeroJuizo { get; set; }

        [JsonPropertyName("descricaoJuizo")]
        public string DescricaoJuizo { get; set; }

        [JsonPropertyName("dataProtocoloJudExecucao")]
        public string DataProtocoloJudExecucao { get; set; }

        [JsonPropertyName("dataDistribuicaoJudicial")]
        public string DataDistribuicaoJudicial { get; set; }

        [JsonPropertyName("indicadorMoedaTotalInscrito")]
        public string IndicadorMoedaTotalInscrito { get; set; }

        [JsonPropertyName("valorTotalInscritoMoeda")]
        public string ValorTotalInscritoMoeda { get; set; }

        [JsonPropertyName("valorTotalInscritoIndex")]
        public string ValorTotalInscritoIndex { get; set; }

        [JsonPropertyName("indicadorMoedaTotalConsolidado")]
        public string IndicadorMoedaTotalConsolidado { get; set; }

        [JsonPropertyName("valorTotalConsolidadoMoeda")]
        public string ValorTotalConsolidadoMoeda { get; set; }

        [JsonPropertyName("indicadorMoedaTotalRemanescente")]
        public string IndicadorMoedaTotalRemanescente { get; set; }

        [JsonPropertyName("valorRemanescenteMoeda")]
        public string ValorRemanescenteMoeda { get; set; }

        [JsonPropertyName("valorRemanescenteIndex")]
        public string ValorRemanescenteIndex { get; set; }

        [JsonPropertyName("dataDevolucaoProcesso")]
        public string DataDevolucaoProcesso { get; set; }

        [JsonPropertyName("numeroAutoInfracao")]
        public string NumeroAutoInfracao { get; set; }

        [JsonPropertyName("indicadorPrescricaoSV8")]
        public string IndicadorPrescricaoSV8 { get; set; }

        [JsonPropertyName("dataDecretacaoFalencia")]
        public string DataDecretacaoFalencia { get; set; }

        [JsonPropertyName("dataFimProcurador")]
        public string DataFimProcurador { get; set; }

        [JsonPropertyName("numeroImovelITR")]
        public string NumeroImovelITR { get; set; }

        [JsonPropertyName("dataExtincaoInscricao")]
        public string DataExtincaoInscricao { get; set; }

        [JsonPropertyName("MotivoSuspensaoExigibilidade")]
        public string MotivoSuspensaoExigibilidade { get; set; }

        [JsonPropertyName("numeroRipSpu")]
        public string NumeroRipSpu { get; set; }

        [JsonPropertyName("indicadorAnaliseOrgaoOrigem")]
        public string IndicadorAnaliseOrgaoOrigem { get; set; }

        [JsonPropertyName("motivoExtincaoInscricao")]
        public string MotivoExtincaoInscricao { get; set; }

        [JsonPropertyName("indicadorProtImpedAjuiz")]
        public string IndicadorProtImpedAjuiz { get; set; }

        [JsonPropertyName("numeroAgrupamento")]
        public string NumeroAgrupamento { get; set; }

        [JsonPropertyName("numeroInscricaoOriginal")]
        public string NumeroInscricaoOriginal { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada1")]
        public string NumeroInscricaoDerivada1 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada2")]
        public string NumeroInscricaoDerivada2 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada3")]
        public string NumeroInscricaoDerivada3 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada4")]
        public string NumeroInscricaoDerivada4 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada5")]
        public string NumeroInscricaoDerivada5 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada6")]
        public string NumeroInscricaoDerivada6 { get; set; }

        [JsonPropertyName("numeroInscricaoDerivada7")]
        public string NumeroInscricaoDerivada7 { get; set; }

        [JsonPropertyName("dcomp")]
        public string Dcomp { get; set; }

        [JsonPropertyName("descricaoNaoCalculado")]
        public string DescricaoNaoCalculado { get; set; }

        [JsonPropertyName("codigoMunicipioSPU")]
        public int CodigoMunicipioSPU { get; set; }

        [JsonPropertyName("codigoSistemaOrigem")]
        public string CodigoSistemaOrigem { get; set; }

        [JsonPropertyName("descricaoSistemaOrigem")]
        public string DescricaoSistemaOrigem { get; set; }
    }
}
