using Domain.Models.Endereco;
using Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes.ValidationsTeste
{
    public class EnderecoEntradaValidationTeste
    {
        private readonly EnderecoEntradaValidation _enderecoEntradaValidation;

        public EnderecoEntradaValidationTeste()
        {
            _enderecoEntradaValidation = new EnderecoEntradaValidation();
        }

        [Trait("Validacoes", nameof(EnderecoEntradaValidation))]
        [Fact(DisplayName = "Endereço Entrada Validation - Sucesso")]
        public void EnderecoEntradaValidationSucesso()
        {
            var enderecoEntrada = new EnderecoEntrada()
            {
                Bairro = "Centro",
                Cep = "",
                Logradouro = ""
            };

            var valid = _enderecoEntradaValidation.Validate(enderecoEntrada);

            Assert.True(valid.IsValid);
        }

        [Trait("Validacoes", nameof(EnderecoEntradaValidation))]
        [Fact(DisplayName = "Endereço Entrada Validation - Sem Parametro - Falha")]
        public void EnderecoEntradaValidationSemParametroFalha()
        {
            var enderecoEntrada = new EnderecoEntrada()
            {
                Bairro = "",
                Cep = "",
                Logradouro = ""
            };

            var valid = _enderecoEntradaValidation.Validate(enderecoEntrada);

            Assert.False(valid.IsValid);
            Assert.Equal(1, valid.Errors.Count);
            Assert.Equal(valid.Errors[0].ErrorMessage, Mensagens.PreencherCampos);         

        }
    }
}
