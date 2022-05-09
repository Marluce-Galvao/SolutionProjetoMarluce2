using Domain.Models.Automacoes;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.Automacao
{
    public interface IConsultaPorId
    {
        Task<AutomacaoSaida> ConsultarPorId(int id);
    }
}
