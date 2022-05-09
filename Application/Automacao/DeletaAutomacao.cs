using Domain.Interfaces.Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Resource;
using System;
using System.Threading.Tasks;

namespace Application.Automacao
{
    public class DeletaAutomacao : IDeletaAutomacao
    {
        private readonly IAutomacaoRepositorio _automacaoRepositorio;

        public DeletaAutomacao(IAutomacaoRepositorio automacaoRepositorio)
        {
            _automacaoRepositorio = automacaoRepositorio ?? throw new ArgumentNullException(nameof(automacaoRepositorio));
        }

        public async Task DeletarAutomacao(int id)
        {
            if (id <= 0) throw new Exception(string.Format(Mensagens.MaiorQue,"Id","0"));

            var automacao = await _automacaoRepositorio.ConsultaPorId(id);

            if (automacao == null)
                throw new Exception(Mensagens.RegistroNaoEncontrado);
            else
                await _automacaoRepositorio.Deletar(automacao);
        }

    }
}
