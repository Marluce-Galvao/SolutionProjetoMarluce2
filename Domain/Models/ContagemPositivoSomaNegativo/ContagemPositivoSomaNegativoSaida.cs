namespace Domain.Models.ContagemPositivoSomaNegativo
{
    public class ContagemPositivoSomaNegativoSaida
    {
        public int QuantidadeDePositivos { get; private set; }
        public int SomaDeNegativos { get; private set; }
        public ContagemPositivoSomaNegativoSaida(int quantidadeDePositivos, int somaDeNegativos)
        {
            QuantidadeDePositivos = quantidadeDePositivos;
            SomaDeNegativos = somaDeNegativos;
        }        
    }
}
