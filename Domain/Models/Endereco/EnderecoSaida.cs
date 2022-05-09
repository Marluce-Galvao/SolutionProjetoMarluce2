namespace Domain.Models.Endereco
{
    public class EnderecoSaida
    {
        public string Bairropopular { get; private set; }
        public string Cep { get; private set; }
        public string Idbairro { get; private set; }
        public string Id { get; private set; }
        public string Idlogradouro { get; private set; }
        public string Idregional { get; private set; }
        public string Nomelogradouro { get; private set; }
        public string Nomeregional { get; private set; }
        public string Numero { get; private set; }
        public string Tipologradouro { get; private set; }
        public string Wkt { get; private set; }
        public string Codregional { get; private set; }
        public string Idterritorio { get; private set; }
        public string Siglaterritorio { get; private set; }
        public string Letra { get; private set; }

        public EnderecoSaida(string bairropopular, string cep, string idbairro, string id, string idlogradouro, string idregional,
                             string nomelogradouro, string nomeregional, string numero, string tipologradouro, string wkt,
                             string codregional, string idterritorio, string siglaterritorio, string letra)
        {
            Bairropopular = bairropopular;
            Cep = cep;
            Idbairro = idbairro;
            Id = id;
            Idlogradouro = idlogradouro;
            Idregional = idregional;
            Nomelogradouro = nomelogradouro;
            Nomeregional = nomeregional;
            Numero = numero;
            Tipologradouro = tipologradouro;
            Wkt = wkt;
            Codregional = codregional;
            Idterritorio = idterritorio;
            Siglaterritorio = siglaterritorio;
            Letra = letra;
        }       
    }
}
