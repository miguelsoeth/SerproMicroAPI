namespace SerproMicroAPI.ViewModel.Mix
{
    //DepsMixCredilinkInformacaoCadastralPFVM
    public class DepsMixSerproCPFVM
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Identidade { get; set; }
        public string NomeMae { get; set; }
        public string Idade { get; set; }
        public string SituacaoCadastral { get; set; }
        public string DataNascimento { get; set; }
        public string RendaPresumida { get; set; }
        public string MensagemErroRendaPresumida { get; set; }
        public string Escolaridade { get; set; }
        public string Nacionalidade { get; set; }
        public string DataInscricao { get; set; }
        public string DataHoraReceita { get; set; }
        public string CodigoControleReceita { get; set; }
        public DepsMixCredilinkDadosCadastraisVM DadosCadastrais { get; set; }
        public DepsMixCredilinkObitoVM Obito { get; set; }
        public DepsMixCredilinkPoliticamenteExpostaVM PoliticamenteExposta { get; set; }
    }

    public class DepsMixCredilinkDadosCadastraisVM
    {
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
    }

    public class DepsMixCredilinkObitoVM
    {
        public string Obito { get; set; }
        public string DataObito { get; set; }
        public string NomeCartorio { get; set; }
    }

    public class DepsMixCredilinkPoliticamenteExpostaVM
    {
        public string Funcao { get; set; }
        public string Orgao { get; set; }
        public string DataInicioExercicio { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataFimExercicio { get; set; }
    }
}
