using Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Resource;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Automacao
{
    public class DeletaAutomacaoTeste
    {
        private DeletaAutomacao _deletaAutomacao;

        [Trait("Serviços", nameof(DeletaAutomacao))]
        [Fact(DisplayName = "Deletar Automacao - Sucesso")]
        public async Task DeletarAutomacaoSucesso()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();

            mockIAutomacaoRepositorio.Setup(s => s.ConsultaPorId(It.IsAny<int>()))
                .ReturnsAsync(new Domain.Entity.Automacao());

            _deletaAutomacao = new DeletaAutomacao(mockIAutomacaoRepositorio.Object);

            await _deletaAutomacao.DeletarAutomacao(2);

            Assert.True(true);
        }

        [Trait("Serviços", nameof(DeletaAutomacao))]
        [Fact(DisplayName = "Deletar Automacao - Id Menor do que 1 - Falha")]
        public async Task DeletarAutomacaoIdMenorQue1Falha()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();

            _deletaAutomacao = new DeletaAutomacao(mockIAutomacaoRepositorio.Object);

            var result = await Assert.ThrowsAnyAsync<Exception>(async () => await _deletaAutomacao.DeletarAutomacao(-8));

            Assert.NotNull(result);
            Assert.Equal(result.Message, string.Format(Mensagens.MaiorQue,"Id", "0"));
        }

        [Trait("Serviços", nameof(DeletaAutomacao))]
        [Fact(DisplayName = "Deletar Automacao - Registro não encontrado - Falha")]
        public async Task DeletarAutomacaoRegistroNaoEncontradoFalha()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();

            mockIAutomacaoRepositorio.Setup(s => s.ConsultaPorId(It.IsAny<int>()))
                .ReturnsAsync((Domain.Entity.Automacao)null);

            _deletaAutomacao = new DeletaAutomacao(mockIAutomacaoRepositorio.Object);

            var result = await Assert.ThrowsAnyAsync<Exception>(async () => await _deletaAutomacao.DeletarAutomacao(5));

            Assert.NotNull(result);
            Assert.Equal(result.Message, Mensagens.RegistroNaoEncontrado);
        }


    }
}
