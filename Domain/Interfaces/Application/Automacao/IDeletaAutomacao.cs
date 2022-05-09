using System.Threading.Tasks;

namespace Domain.Interfaces.Application.Automacao
{
    public interface IDeletaAutomacao
    {
        Task DeletarAutomacao(int id);
    }
}
