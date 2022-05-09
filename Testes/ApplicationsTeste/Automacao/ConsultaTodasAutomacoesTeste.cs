using Application.Automacao;
using AutoMapper;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Automacao
{
    public class ConsultaTodasAutomacoesTeste
    {
        private ConsultaTodasAutomacoes _consultaTodasAutomacoes;


        [Trait("Serviços", nameof(ConsultaTodasAutomacoes))]
        [Fact(DisplayName = "Consulta Todas Automacoes - Sucesso")]
        public async Task ConsultaTodasAutomacoesSucesso()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();
            Mock<IMapper> mockIMapper = new Mock<IMapper>();

            mockIAutomacaoRepositorio.Setup(s => s.ConsultaTodos()).ReturnsAsync(new List<Domain.Entity.Automacao>()
            {
             new Domain.Entity.Automacao()
            });

            mockIMapper.SetReturnsDefault(new AutomacaoSaida(3,DateTime.Now,"Nome","Testando",true));

            _consultaTodasAutomacoes = new ConsultaTodasAutomacoes(mockIMapper.Object, mockIAutomacaoRepositorio.Object);

            var result= await _consultaTodasAutomacoes.ConsultarTodos();

            Assert.NotNull(result);
            Assert.Equal(1, result.Count);

        }

    }
}
