using Domain.Models.ContagemPositivoSomaNegativo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application.ContagemPositivoSomaNegativo
{
    public interface IContagemPositivoSomaNegativo
    {
        Task<ContagemPositivoSomaNegativoSaida> ContarPositivosESomarNegativos(ContagemPositivoSomaNegativoEntrada contagemPositivoSomaNegativoEntrada);
    }
}
