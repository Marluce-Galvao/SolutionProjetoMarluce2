using AutoMapper;
using Domain.Interfaces.Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Domain.Resource;
using System;
using System.Threading.Tasks;

namespace Application.Automacao
{
    public class ConsultaPorId : IConsultaPorId
    {
        private readonly IAutomacaoRepositorio _automacaoRepositorio;
        private readonly IMapper _mapper;

        public ConsultaPorId(IAutomacaoRepositorio automacaoRepositorio, IMapper mapper)
        {
            _automacaoRepositorio = automacaoRepositorio ?? throw new ArgumentNullException(nameof(automacaoRepositorio));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<AutomacaoSaida> ConsultarPorId(int id)
        {
            if (id <= 0) throw new Exception(string.Format(Mensagens.MaiorQue, "Id","0"));

            var automacao = await _automacaoRepositorio.ConsultaPorId(id);

            return _mapper.Map<AutomacaoSaida>(automacao);
        }
    }
}
