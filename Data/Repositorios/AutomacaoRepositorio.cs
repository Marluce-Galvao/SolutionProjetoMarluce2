using Domain;
using Domain.Entity;
using Domain.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositorios
{
    public class AutomacaoRepositorio : IAutomacaoRepositorio
    {
        private readonly Contexto _contexto;

        public AutomacaoRepositorio(Contexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
        }

        public async Task<List<Automacao>> ConsultaTodos()
        {
            return await _contexto.Automacao.ToListAsync();
        }

        public async Task<Automacao> ConsultaPorId(int id)
        {
            return await _contexto.Automacao.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Deletar(Automacao automacao)
        {
            _contexto.Automacao.Remove(automacao);
            _contexto.SaveChanges();
        }

        public async Task Inserir(Automacao automacao)
        {
            await _contexto.Automacao.AddAsync(automacao);
            await _contexto.SaveChangesAsync();
        }

        public async Task Alterar(Automacao automacao)
        {
            _contexto.Automacao.Update(automacao);
            _contexto.SaveChanges();
        }
    }
}
