using AutoMapper;
using Domain.Interfaces.Application.BuscaEndereco;
using Domain.Interfaces.Proxies;
using Domain.Models.Endereco;
using Domain.RefitConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Endereco
{
    public class BuscaEndereco : IBuscaEndereco
    {
        private readonly IProxyFabric<IBuscaEnderecoPrefeituraProxy> _buscaEnderecoPrefeituraProxy;
        private readonly IMapper _mapper;

        public BuscaEndereco(IProxyFabric<IBuscaEnderecoPrefeituraProxy> buscaEnderecoPrefeituraProxy, IMapper mapper)
        {
            _buscaEnderecoPrefeituraProxy = buscaEnderecoPrefeituraProxy ?? throw new ArgumentNullException(nameof(buscaEnderecoPrefeituraProxy));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<EnderecoSaida>> ConsultarEndereco(EnderecoEntrada enderecoEntrada)
        {
            var ConsultaEnderecoDto = await _buscaEnderecoPrefeituraProxy.Proxy.BuscarEnderecoPrefeitura(enderecoEntrada.Logradouro, 
                                                                                                         enderecoEntrada.Cep,
                                                                                                         enderecoEntrada.Bairro);

            return ConsultaEnderecoDto.Endereco.Select(s => _mapper.Map<EnderecoSaida>(s)).ToList();
        }
    }
}
