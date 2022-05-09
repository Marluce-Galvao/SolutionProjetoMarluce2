using Domain.Models.Endereco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.BuscaEndereco
{
    public interface IBuscaEndereco
    {
        Task<IEnumerable<EnderecoSaida>> ConsultarEndereco(EnderecoEntrada enderecoEntrada);
    }
}
