using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace SerproMicroAPI.ViewModel.DividaAtiva
{
    public class SerproDevedorVM
    {
        [JsonPropertyName("numeroInscricao")]
        public string NumeroInscricao { get; set; }

        [JsonPropertyName("numeroProcesso")]
        public string NumeroProcesso { get; set; }

        [JsonPropertyName("situacaoInscricao")]
        public string SituacaoInscricao { get; set; }

        [JsonPropertyName("situacaoDescricao")]
        public string SituacaoDescricao { get; set; }

        [JsonPropertyName("nomeDevedor")]
        public string NomeDevedor { get; set; }

        [JsonPropertyName("tipoDevedor")]
        public string TipoDevedor { get; set; }

        [JsonPropertyName("valorTotalConsolidadoMoeda")]
        public string ValorTotalConsolidadoMoeda { get; set; }

        [JsonPropertyName("cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonPropertyName("codigoSida")]
        public string CodigoSida { get; set; }

        [JsonPropertyName("nomeUnidade")]
        public string NomeUnidade { get; set; }

        [JsonPropertyName("codigoComprot")]
        public string CodigoComprot { get; set; }

        [JsonPropertyName("codigoUorg")]
        public string CodigoUorg { get; set; }
    }
}

