using Domain.Models.Automacoes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.Automacao
{
    public interface IAlteraAutomacao
    {
        Task UpdateAutomacao(int id, AutomacaoEntrada automacaoEntrada);
    }
}
