using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapeamentos
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration Register()
        {
            return new MapperConfiguration(c => {
                c.AddProfile(new DominioParaModeloMapping());
                c.AddProfile(new ModeloParaDominioMapping());
            });
        }
    }
}
