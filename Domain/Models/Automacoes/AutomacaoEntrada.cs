using Domain.Resource;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Automacoes
{
    public class AutomacaoEntrada
    {        
        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long IdVacina { get; set; }
        public long IdCliente { get; set; }
        public long IdAutomacao { get; set; }
        public bool EstaAtivo { get; set; }
    }

    public class AutomacaoEntradaValidation : AbstractValidator<AutomacaoEntrada>
    {
        public AutomacaoEntradaValidation()
        {
            RuleFor(r => r.IdUsuario)
                .GreaterThan(0)
                .WithMessage(string.Format(Mensagens.MaiorQue, "Id do Usuario","0"));

            RuleFor(r => r.Nome)
               .NotEmpty()
               .WithMessage(string.Format(Mensagens.CampoObrigatorio, "Nome"));

            RuleFor(r => r.Descricao)
             .NotEmpty()
             .WithMessage(string.Format(Mensagens.CampoObrigatorio, "Descrição"));

            RuleFor(r => r.IdVacina)
                .GreaterThan(0)
                .WithMessage(string.Format(Mensagens.MaiorQue, "Id da vacina", "0"));

            RuleFor(r => r.IdCliente)
                .GreaterThan(0)
                .WithMessage(string.Format(Mensagens.MaiorQue, "Id do cliente", "0"));

            RuleFor(r => r.IdAutomacao)
                .GreaterThan(0)
                .WithMessage(string.Format(Mensagens.MaiorQue, "Id da automação", "0"));
        }
    }

}
