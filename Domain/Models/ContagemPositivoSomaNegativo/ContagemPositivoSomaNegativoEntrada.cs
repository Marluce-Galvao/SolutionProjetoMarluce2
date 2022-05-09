using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Resource;
using FluentValidation;

namespace Domain.Models.ContagemPositivoSomaNegativo
{
    public class ContagemPositivoSomaNegativoEntrada
    {
        public List<int> ListaDeNumeros { get; set; }
    }

    public class ContagemPositivoSomaNegativoEntradaValidation : AbstractValidator<ContagemPositivoSomaNegativoEntrada>
    {
        public ContagemPositivoSomaNegativoEntradaValidation()
        {
            RuleFor(r => r.ListaDeNumeros)
                .NotEmpty()
                .WithMessage(string.Format(Mensagens.CampoObrigatorio, "Lista de Número"));

            When(w => w.ListaDeNumeros.Count > 0, () =>
            {
                RuleFor(r => r.ListaDeNumeros.Any(a => a < 0))
                    .Equal(true)
                    .WithMessage(string.Format(Mensagens.ListaNegativaEPositiva, "Lista de números"));

                RuleFor(r => r.ListaDeNumeros.Any(a => a > 0))
                  .Equal(true)
                  .WithMessage(string.Format(Mensagens.ListaNegativaEPositiva, "Lista de números"));
            });
        }
    }
}
