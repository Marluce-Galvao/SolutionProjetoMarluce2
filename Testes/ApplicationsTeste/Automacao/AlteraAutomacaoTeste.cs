using Application.Automacao;
using AutoMapper;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Domain.Resource;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Automacao
{
    public class AlteraAutomacaoTeste
    {
        private AlteraAutomacao _alteraAutomacao;

        [Trait("Serviços", nameof(AlteraAutomacao))]
        [Fact(DisplayName = "Altera Automação - Sucesso")]
        public async Task AlteraAutomacaoSucesso()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();
           
            mockIAutomacaoRepositorio.Setup(s => s.ConsultaPorId(It.IsAny<int>()))
                .ReturnsAsync(new Domain.Entity.Automacao());

            _alteraAutomacao = new AlteraAutomacao(mockIAutomacaoRepositorio.Object);

            await _alteraAutomacao.UpdateAutomacao(1, new AutomacaoEntrada());

            Assert.True(true);
        }

        [Trait("Serviços", nameof(AlteraAutomacao))]
        [Fact(DisplayName = "Altera Automacao - Id menor que 0 - Falha")]
        public async Task AlteraAutomacaoMenorQueZeroFalha()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();

            _alteraAutomacao = new AlteraAutomacao(mockIAutomacaoRepositorio.Object);

            var result = await Assert.ThrowsAnyAsync<Exception>(async () => await _alteraAutomacao.UpdateAutomacao(0, new AutomacaoEntrada()));

            Assert.NotNull(result);
            Assert.Equal(result.Message, string.Format(Mensagens.MaiorQue, "Id", "0"));
        }

        [Trait("Serviços", nameof(AlteraAutomacao))]
        [Fact(DisplayName = "Altera Automacao - Registro não encontrado - Falha")]
        public async Task AlteraAutomacaoRegistroNaoEncontradoFalha()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();

            mockIAutomacaoRepositorio.Setup(s => s.ConsultaPorId(It.IsAny<int>()))
               .ReturnsAsync((Domain.Entity.Automacao)null);

            _alteraAutomacao = new AlteraAutomacao(mockIAutomacaoRepositorio.Object);

            var result = await Assert.ThrowsAnyAsync<Exception>(async () => await _alteraAutomacao.UpdateAutomacao(4, new AutomacaoEntrada()));

            Assert.NotNull(result);
            Assert.Equal(result.Message, Mensagens.RegistroNaoEncontrado);
        }
    }
}
