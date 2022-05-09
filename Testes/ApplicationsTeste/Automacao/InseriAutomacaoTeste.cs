using Application.Automacao;
using AutoMapper;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes.ApplicationsTeste.Automacao
{
    public class InseriAutomacaoTeste
    {
        private InseriAutomacao _inseriAutomacao;       

        [Trait("Serviços", nameof(InseriAutomacao))]
        [Fact(DisplayName = "Inseri Automacao - Sucesso")]
        public async Task InseriAutomacaoSucesso()
        {
            Mock<IAutomacaoRepositorio> mockIAutomacaoRepositorio = new Mock<IAutomacaoRepositorio>();
            Mock<IMapper> mockIMapper = new Mock<IMapper>();

            mockIMapper.SetReturnsDefault(new Domain.Entity.Automacao());

            _inseriAutomacao = new InseriAutomacao(mockIMapper.Object, mockIAutomacaoRepositorio.Object);

            await _inseriAutomacao.InserirNovaAutomacao(new AutomacaoEntrada());

            Assert.True(true);
        }
    }
}
