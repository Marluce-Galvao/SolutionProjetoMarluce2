using Application.Automacao;
using AutoMapper;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Domain.Resource;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Automacao
{
    public class ConsultaPorIdTeste
    {
        private ConsultaPorId _consultaPorId;

        [Trait("Serviços", nameof(ConsultaPorId))]
        [Fact(DisplayName = "Consulta Automacoes por id - Sucesso")]
        public async Task ConsultaAutomacoesPorIdSucesso()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();
            Mock<IMapper> mockIMapper = new Mock<IMapper>();

            mockIAutomacaoRepositorio.Setup(s => s.ConsultaPorId(It.IsAny<int>()))
                .ReturnsAsync(new Domain.Entity.Automacao());

            mockIMapper.SetReturnsDefault(new AutomacaoSaida(3, DateTime.Now, "Nome", "Testando", true));

            _consultaPorId = new ConsultaPorId(mockIAutomacaoRepositorio.Object, mockIMapper.Object);

            var result = await _consultaPorId.ConsultarPorId(4);

            Assert.NotNull(result);
        }

        [Trait("Serviços", nameof(ConsultaPorId))]
        [Fact(DisplayName = "Consulta Automacoes por id - Id menor que 0 - Falha")]
        public async Task ConsultaAutomacoesPorIdMenorQueZeroFalha()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();
            Mock<IMapper> mockIMapper = new Mock<IMapper>();           

            _consultaPorId = new ConsultaPorId(mockIAutomacaoRepositorio.Object, mockIMapper.Object);

            var result = await Assert.ThrowsAnyAsync<Exception>(async () => await _consultaPorId.ConsultarPorId(-1));

            Assert.NotNull(result);
            Assert.Equal(result.Message, string.Format(Mensagens.MaiorQue, "Id", "0"));
        }
    }
}
