using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerproMicroAPI.ViewModel.CND
{
    public class Certidao
    {
        public int TipoContribuinte { get; set; }
        public string ContribuinteCertidao { get; set; }
        public int TipoCertidao { get; set; }
        public string CodigoControle { get; set; }
        public string DataEmissao { get; set; }
        public string DataValidade { get; set; }
        public string DocumentoPdf { get; set; }
    }

    public class SerproCNDVM
    {
        public string Status { get; set; }
        public string Mensagem { get; set; }
        public Certidao Certidao { get; set; }
    }    
}
