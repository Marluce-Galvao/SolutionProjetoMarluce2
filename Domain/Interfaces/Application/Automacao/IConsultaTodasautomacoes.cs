using Domain.Models.Automacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.Automacao
{
    public interface IConsultaTodasautomacoes
    {
        Task<List<AutomacaoSaida>> ConsultarTodos();
    }
}
