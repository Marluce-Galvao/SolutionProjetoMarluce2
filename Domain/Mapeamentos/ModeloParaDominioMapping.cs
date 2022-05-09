using AutoMapper;
using Domain.Entity;
using Domain.Models.Automacoes;
using System;

namespace Domain.Mapeamentos
{
    public class ModeloParaDominioMapping : Profile
    {
        public ModeloParaDominioMapping()
        {
            CreateMap<AutomacaoEntrada, Automacao>()
                  .ConstructUsing(c => new Automacao(0,DateTime.Now,c.IdUsuario,DateTime.Now,c.IdUsuario,c.Nome, 
                                                     c.Descricao, c.IdVacina,c.IdCliente, c.IdAutomacao,"",c.EstaAtivo));
        }
    }
}
