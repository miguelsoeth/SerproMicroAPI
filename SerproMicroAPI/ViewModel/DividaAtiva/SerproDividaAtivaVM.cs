using System.Collections.Generic;

namespace SerproMicroAPI.ViewModel.DividaAtiva
{
    public class SerproDividaAtivaVM
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public List<SerproDevedorVM> Devedor { get; set; }
        public List<SerproInscricaoVM> Inscricao { get; set; }
    }
}
