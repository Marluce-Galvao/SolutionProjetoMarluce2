using Application.Endereco;
using AutoMapper;
using Domain.Dtos.Endereco;
using Domain.Interfaces.Proxies;
using Domain.Models.Endereco;
using Domain.RefitConfig;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Endereco
{
    public class ConsultaEnderecoTeste
    {
        private BuscaEndereco _buscaEndereco;

        [Trait("Serviços", nameof(BuscaEndereco))]
        [Fact(DisplayName = "Busca Endereco - Sucesso")]
        public async Task ConsultarEnderecoSucesso()
        {
            Mock<IProxyFabric<IBuscaEnderecoPrefeituraProxy>> mockBuscaEnderecoPrefeituraProxy = new Mock<IProxyFabric<IBuscaEnderecoPrefeituraProxy>>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            mockBuscaEnderecoPrefeituraProxy
                .Setup(s => s.Proxy.BuscarEnderecoPrefeitura(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .ReturnsAsync(new ConsultaEnderecoDto(
                    new List<EnderecoDto>() {new EnderecoDto("bairropopular","cep","idbairro","id",
                                                             "idlogradouro","idregional","nomelogradouro",
                                                             "nomeregional","numero","tipologradouro","wkt",
                                                             "codregional","idterritorio","siglaterritorio","letra") }
                    ));

            mockMapper.SetReturnsDefault(new EnderecoSaida("bairropopular", "cep", "idbairro", "id",
                                                             "idlogradouro", "idregional", "nomelogradouro",
                                                             "nomeregional", "numero", "tipologradouro", "wkt",
                                                             "codregional", "idterritorio", "siglaterritorio", "letra"));

            _buscaEndereco = new BuscaEndereco(mockBuscaEnderecoPrefeituraProxy.Object, mockMapper.Object);

            var result = await _buscaEndereco.ConsultarEndereco(new EnderecoEntrada());

            Assert.NotNull(result);
            Assert.Equal(1,result.Count());
        }

    }
}
