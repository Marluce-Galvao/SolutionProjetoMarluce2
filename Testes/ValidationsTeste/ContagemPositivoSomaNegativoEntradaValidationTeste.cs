using Domain.Models.ContagemPositivoSomaNegativo;
using Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes.ValidationsTeste
{
    public class ContagemPositivoSomaNegativoEntradaValidationTeste
    {
        private readonly ContagemPositivoSomaNegativoEntradaValidation _contagemPositivoSomaNegativoEntradaValidation;

        public ContagemPositivoSomaNegativoEntradaValidationTeste()
        {
            _contagemPositivoSomaNegativoEntradaValidation = new ContagemPositivoSomaNegativoEntradaValidation();
        }

        [Trait("Validacoes", nameof(ContagemPositivoSomaNegativoEntradaValidation))]
        [Fact(DisplayName = "Contagem Positivo Soma Negativo Entrada Validation - Sucesso")]
        public void ContagemPositivoSomaNegativoEntradaValidationSucesso()
        {
            var ContagemPositivoSomaNegativoEntrada = new ContagemPositivoSomaNegativoEntrada() {
                ListaDeNumeros = new List<int>() {1,2,-3,4,5}
            };

            var valid = _contagemPositivoSomaNegativoEntradaValidation.Validate(ContagemPositivoSomaNegativoEntrada);

            Assert.True(valid.IsValid);
        }

        [Trait("Validacoes", nameof(ContagemPositivoSomaNegativoEntradaValidation))]
        [Fact(DisplayName = "Contagem Positivo Soma Negativo Entrada Validation - Lista Vazia - Falha")]
        public void ContagemPositivoSomaNegativoEntradaValidationListaVaziaFalha()
        {
            var ContagemPositivoSomaNegativoEntrada = new ContagemPositivoSomaNegativoEntrada()
            {
                ListaDeNumeros = new List<int>() {}
            };

            var valid = _contagemPositivoSomaNegativoEntradaValidation.Validate(ContagemPositivoSomaNegativoEntrada);

            Assert.False(valid.IsValid);
            Assert.Equal(1, valid.Errors.Count);
            Assert.Equal(valid.Errors[0].ErrorMessage, string.Format(Mensagens.CampoObrigatorio, "Lista de Número"));
        }

        [Trait("Validacoes", nameof(ContagemPositivoSomaNegativoEntradaValidation))]
        [Fact(DisplayName = "Contagem Positivo Soma Negativo Entrada Validation - Falta numero positivo- Falha")]
        public void ContagemPositivoSomaNegativoEntradaValidationFaltaNumeroPositivoFalha()
        {
            var ContagemPositivoSomaNegativoEntrada = new ContagemPositivoSomaNegativoEntrada()
            {
                ListaDeNumeros = new List<int>() {-3,-2,-10}
            };

            var valid = _contagemPositivoSomaNegativoEntradaValidation.Validate(ContagemPositivoSomaNegativoEntrada);

            Assert.False(valid.IsValid);
            Assert.Equal(1, valid.Errors.Count);
            Assert.Equal(valid.Errors[0].ErrorMessage, string.Format(Mensagens.ListaNegativaEPositiva, "Lista de números"));
        }

        [Trait("Validacoes", nameof(ContagemPositivoSomaNegativoEntradaValidation))]
        [Fact(DisplayName = "Contagem Positivo Soma Negativo Entrada Validation - Falta numero Negativo- Falha")]
        public void ContagemPositivoSomaNegativoEntradaValidationFaltaNumeroNegativoFalha()
        {
            var ContagemPositivoSomaNegativoEntrada = new ContagemPositivoSomaNegativoEntrada()
            {
                ListaDeNumeros = new List<int>() { 3, 2, 10 }
            };

            var valid = _contagemPositivoSomaNegativoEntradaValidation.Validate(ContagemPositivoSomaNegativoEntrada);

            Assert.False(valid.IsValid);
            Assert.Equal(1, valid.Errors.Count);
            Assert.Equal(valid.Errors[0].ErrorMessage, string.Format(Mensagens.ListaNegativaEPositiva, "Lista de números"));
        }


    }
}
