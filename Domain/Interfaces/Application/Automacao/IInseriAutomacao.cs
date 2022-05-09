using Domain.Models.Automacoes;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.Automacao
{
    public interface IInseriAutomacao
    {
        Task InserirNovaAutomacao(AutomacaoEntrada automacaoEntrada);
    }
}
