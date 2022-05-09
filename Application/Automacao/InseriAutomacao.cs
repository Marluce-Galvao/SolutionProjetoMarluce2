using AutoMapper;
using Domain.Interfaces.Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using System.Threading.Tasks;

namespace Application.Automacao
{
    public class InseriAutomacao : IInseriAutomacao
    {
        private readonly IMapper _mapper;
        private readonly IAutomacaoRepositorio _automacaoRepositorio;

        public InseriAutomacao(IMapper mapper, IAutomacaoRepositorio automacaoRepositorio)
        {
            _mapper = mapper;
            _automacaoRepositorio = automacaoRepositorio;
        }
        public async Task InserirNovaAutomacao(AutomacaoEntrada automacaoEntrada)
        {
            var automacao = _mapper.Map<Domain.Entity.Automacao>(automacaoEntrada);
            await _automacaoRepositorio.Inserir(automacao);
        }
    }
}
