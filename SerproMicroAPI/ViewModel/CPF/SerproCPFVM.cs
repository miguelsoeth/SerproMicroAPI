using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerproMicroAPI.ViewModel.CPF
{
    public class SerproCPFVM
    {
        public string Ni { get; set; }
        public string Nome { get; set; }
        public SituacaoSerproVM Situacao { get; set; }
        public string Nascimento { get; set; }
        public string Obito { get; set; }
    }
}
