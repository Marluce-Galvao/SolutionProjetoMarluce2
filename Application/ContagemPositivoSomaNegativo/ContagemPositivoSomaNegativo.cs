using AutoMapper;
using Domain.Interfaces.Application.ContagemPositivoSomaNegativo;
using Domain.Models.ContagemPositivoSomaNegativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ContagemPositivoSomaNegativo
{
    public class ContagemPositivoSomaNegativo : IContagemPositivoSomaNegativo
    {
        private readonly IMapper _mapper;

        public ContagemPositivoSomaNegativo(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ContagemPositivoSomaNegativoSaida> ContarPositivosESomarNegativos(ContagemPositivoSomaNegativoEntrada contagemPositivoSomaNegativoEntrada)
        {
            var contagemPositivos = 0;
            var SomaNegativos = 0;

            foreach (var numero in contagemPositivoSomaNegativoEntrada.ListaDeNumeros)
            {
                if (numero <= 0)
                    SomaNegativos += numero;
                else if(numero > 0)
                    contagemPositivos++;
            }        
            return _mapper.Map<ContagemPositivoSomaNegativoSaida>(Tuple.Create(contagemPositivos, SomaNegativos));
        }
    }
}
