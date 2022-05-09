using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositorios
{
    public interface IAutomacaoRepositorio
    {
        Task<List<Automacao>> ConsultaTodos();
        Task<Automacao> ConsultaPorId(int id);
        Task Deletar(Automacao automacao);
        Task Inserir(Automacao automacao);
        Task Alterar(Automacao automacao);
    }
}
