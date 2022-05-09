using System;

namespace Domain.Entity
{
    public class Automacao
    {
        public Automacao() {}

        public Automacao(long id, DateTime creationTime, long creatorUserId, DateTime lastModificationTime,
                         long lastModifierUserId, string nome, string descricao, long vacinaId, 
                         long clienteId, long automacaoTriggerId, string emMonitoramento, bool status)
        {
            Id = id;
            CreationTime = creationTime;
            CreatorUserId = creatorUserId;
            LastModificationTime = lastModificationTime;
            LastModifierUserId = lastModifierUserId;
            Nome = nome;
            Descricao = descricao;
            VacinaId = vacinaId;
            ClienteId = clienteId;
            AutomacaoTriggerId = automacaoTriggerId;
            EmMonitoramento = emMonitoramento;
            Status = status;
        }

        //Exatamente as colunas que a tabela do banco tem
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long CreatorUserId { get; set; }
        public DateTime LastModificationTime { get; set; }
        public long LastModifierUserId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long VacinaId { get; set; }
        public long ClienteId { get; set; }
        public long AutomacaoTriggerId { get; set; }
        public string EmMonitoramento { get; set; }
        public bool Status { get; set; }        
    }
}

