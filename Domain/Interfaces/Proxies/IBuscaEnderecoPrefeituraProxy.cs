using Domain.Constantes;
using Domain.Dtos.Endereco;
using Domain.RefitConfig;
using Refit;
using System.Threading.Tasks;

namespace Domain.Interfaces.Proxies
{
    [ProxyUri(BaseConstante.UrlBuscaEnderecoPrefeitura)]
    public interface IBuscaEnderecoPrefeituraProxy
    {
        [Get("/address")]
        Task<ConsultaEnderecoDto> BuscarEnderecoPrefeitura([Query] string logradouro, string cep, string bairro);

    }
}
