using AutoMapper;
using Domain.Interfaces.Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Automacao
{
    public class ConsultaTodasAutomacoes: IConsultaTodasautomacoes
    {
        private readonly IMapper _mapper;
        private readonly IAutomacaoRepositorio _automacaoRepositorio;

        public ConsultaTodasAutomacoes(IMapper mapper, IAutomacaoRepositorio automacaoRepositorio)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _automacaoRepositorio = automacaoRepositorio ?? throw new ArgumentNullException(nameof(automacaoRepositorio));
        }
        public async Task<List<AutomacaoSaida>> ConsultarTodos()
        {
            var listaDeAutomacoes = await _automacaoRepositorio.ConsultaTodos();

            return listaDeAutomacoes.Select(s => _mapper.Map<AutomacaoSaida>(s)).ToList();
        }
    }
}
