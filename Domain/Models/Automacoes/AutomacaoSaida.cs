using System;

namespace Domain.Models.Automacoes
{
    public class AutomacaoSaida
    {
        public AutomacaoSaida(long id, DateTime dataDaCriacao, string nome, string descricao, bool status)
        {
            Id = id;
            DataDaCriacao = dataDaCriacao;
            Nome = nome;
            Descricao = descricao;
            Status = status;
        }

        public long Id { get; private set; }
        public DateTime DataDaCriacao { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Status { get; private set; }
    }
}
