using AutoMapper;
using Domain.Dtos.Endereco;
using Domain.Entity;
using Domain.Models.Automacoes;
using Domain.Models.ContagemPositivoSomaNegativo;
using Domain.Models.Endereco;
using System;

namespace Domain.Mapeamentos
{
    public class DominioParaModeloMapping : Profile
    {
        public DominioParaModeloMapping()
        {
            CreateMap<Tuple<int, int>, ContagemPositivoSomaNegativoSaida>()
                .ConstructUsing(c => new ContagemPositivoSomaNegativoSaida(c.Item1,c.Item2));

            CreateMap<Automacao, AutomacaoSaida>()
                .ConstructUsing(c => new AutomacaoSaida(c.Id, c.CreationTime, c.Nome, c.Descricao, c.Status));

            CreateMap<EnderecoDto, EnderecoSaida>()
                .ConstructUsing(c => new EnderecoSaida(c.Bairropopular, c.Cep, c.Idbairro, c.Id, c.Idlogradouro, c.Idregional,
                             c.Nomelogradouro, c.Nomeregional, c.Numero, c.Tipologradouro, c.Wkt,
                             c.Codregional, c.Idterritorio, c.Siglaterritorio, c.Letra));            
        }
    }
}
