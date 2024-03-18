using SerproMicroAPI.ViewModel.CND;
using SerproMicroAPI.ViewModel.CNPJ;
using SerproMicroAPI.ViewModel.CPF;
using SerproMicroAPI.ViewModel.DividaAtiva;
using SerproMicroAPI.ViewModel.Mix;
using System.Net;

namespace SerproMicroAPI.ViewModel
{
    public class SerproVM
    {
        public HttpStatusCode Status { get; set; }
        public string Messagem { get; set; }
        public DepsMixSerproDividaAtivaVM dividaAtiva { get; set; }
        public DepsMixSerproCPFVM cpf { get; set; }
        public DepsMixSerproCNDVM cnd { get; set; }
        public DepsMixSerproCNPJVM cnpj { get; set; }
    }
}
