using Domain.Resource;
using FluentValidation;

namespace Domain.Models.Endereco
{
    public class EnderecoEntrada
    {
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
    }

    public class EnderecoEntradaValidation : AbstractValidator<EnderecoEntrada>
    {
        public EnderecoEntradaValidation()
        {
            When(w => string.IsNullOrEmpty(w.Logradouro) && string.IsNullOrEmpty(w.Cep) && string.IsNullOrEmpty(w.Bairro), () =>
            {
                RuleFor(r => false)
                    .Equal(true)
                    .WithMessage(Mensagens.PreencherCampos);
            });
        }
    }

}
