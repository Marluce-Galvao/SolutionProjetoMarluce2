using Domain.Models.Automacoes;
using Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes.ValidationsTeste
{
    public class AutomacaoEntradaValidationTeste
    {
        private readonly AutomacaoEntradaValidation _automacaoEntradaValidation;

        public AutomacaoEntradaValidationTeste()
        {
            _automacaoEntradaValidation = new AutomacaoEntradaValidation();
        }

        [Trait("Validacoes",nameof(AutomacaoEntradaValidation))]
        [Fact(DisplayName = "Automacao Entrada Validation - Sucesso")]
        public void AutomacaoEntradaValidationSucesso()
        {
            var automacaoEntrada = new AutomacaoEntrada()
            {
                Nome = "Nome da Automação",
                Descricao = "Descrição da Automação",
                EstaAtivo = false,
                IdAutomacao = 1,
                IdCliente = 1,
                IdUsuario = 1,
                IdVacina = 1
            };

            var valid = _automacaoEntradaValidation.Validate(automacaoEntrada);

            Assert.True(valid.IsValid);
        }

        [Trait("Validacoes", nameof(AutomacaoEntradaValidation))]
        [Fact(DisplayName = "Automacao Entrada Validation - Obrigatorio - Falha")]
        public void AutomacaoEntradaValidationObrigatorioFalha()
        {
            var automacaoEntrada = new AutomacaoEntrada()
            {
                Nome = "",
                Descricao = "  ",
                EstaAtivo = false,
                IdAutomacao = 0,
                IdCliente = -1,
                IdUsuario = -5,
                IdVacina = 0
            };

            var valid = _automacaoEntradaValidation.Validate(automacaoEntrada);

            Assert.False(valid.IsValid);
            Assert.Equal(6,valid.Errors.Count);
            Assert.Equal(valid.Errors[0].ErrorMessage, string.Format(Mensagens.MaiorQue, "Id do Usuario", "0"));
            Assert.Equal(valid.Errors[1].ErrorMessage, string.Format(Mensagens.CampoObrigatorio, "Nome"));
            Assert.Equal(valid.Errors[2].ErrorMessage,string.Format(Mensagens.CampoObrigatorio, "Descrição"));
            Assert.Equal(valid.Errors[3].ErrorMessage,string.Format(Mensagens.MaiorQue, "Id da vacina", "0"));
            Assert.Equal(valid.Errors[4].ErrorMessage,string.Format(Mensagens.MaiorQue, "Id do cliente", "0"));
            Assert.Equal(valid.Errors[5].ErrorMessage,string.Format(Mensagens.MaiorQue, "Id da automação", "0"));

        }
    }
}
