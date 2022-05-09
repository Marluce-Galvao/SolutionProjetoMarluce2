using AutoMapper;
using Domain.Interfaces.Application.Automacao;
using Domain.Interfaces.Repositorios;
using Domain.Models.Automacoes;
using Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Automacao
{
    public class AlteraAutomacao : IAlteraAutomacao
    {
        private readonly IAutomacaoRepositorio _automacaoRepositorio;

        public AlteraAutomacao(IAutomacaoRepositorio automacaoRepositorio)
        {
            _automacaoRepositorio = automacaoRepositorio ?? throw new ArgumentNullException(nameof(automacaoRepositorio));
        }

        public async Task UpdateAutomacao(int id, AutomacaoEntrada automacaoEntrada)
        {
            if (id <= 0) throw new Exception(string.Format(Mensagens.MaiorQue,"Id","0"));

            var automacao = await _automacaoRepositorio.ConsultaPorId(id);

            if (automacao == null)
                throw new Exception(Mensagens.RegistroNaoEncontrado);
            else
            {
                automacao.CreatorUserId = automacaoEntrada.IdUsuario;
                automacao.ClienteId = automacaoEntrada.IdCliente;
                automacao.Nome = automacaoEntrada.Nome;
                automacao.Descricao = automacaoEntrada.Descricao;
                automacao.VacinaId = automacaoEntrada.IdVacina;
                automacao.AutomacaoTriggerId = automacaoEntrada.IdAutomacao;
                automacao.Status = automacaoEntrada.EstaAtivo;
                automacao.CreationTime = DateTime.Now;
                automacao.LastModificationTime = DateTime.Now;
                automacao.LastModifierUserId = automacaoEntrada.IdUsuario;
                automacao.EmMonitoramento = "";

                await _automacaoRepositorio.Alterar(automacao);
            }
        }
    }
}
