using Microsoft.Extensions.DependencyInjection;
using Domain.Mapeamentos;
using FluentValidation.AspNetCore;
using System.Reflection;
using FluentValidation;
using Domain.Models.ContagemPositivoSomaNegativo;
using Application.ContagemPositivoSomaNegativo;
using Domain.Interfaces.Application.ContagemPositivoSomaNegativo;
using Data;
using Data.Repositorios;
using Domain.Interfaces.Repositorios;
using Domain.Interfaces.Application.Automacao;
using Application.Automacao;
using Domain.Models.Automacoes;
using Application.Endereco;
using Domain.Interfaces.Application.BuscaEndereco;
using Domain.RefitConfig;
using Domain.Models.Endereco;

namespace Ioc
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<Contexto>();
            services.AddScoped(typeof(IProxyFabric<>), typeof(ProxyFabric<>));

            services.AddControllers().AddFluentValidation(opt => {
                    opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });

            #region injecoes serviços
            services.AddScoped<IContagemPositivoSomaNegativo, ContagemPositivoSomaNegativo>();
            services.AddScoped<IConsultaTodasautomacoes, ConsultaTodasAutomacoes>();
            services.AddScoped<IInseriAutomacao, InseriAutomacao>();
            services.AddScoped<IConsultaPorId, ConsultaPorId>();
            services.AddScoped<IDeletaAutomacao, DeletaAutomacao>();
            services.AddScoped<IAlteraAutomacao, AlteraAutomacao>();
            services.AddScoped<IBuscaEndereco, BuscaEndereco>();            
            #endregion

            #region Injeções de validation
            services.AddTransient<IValidator<ContagemPositivoSomaNegativoEntrada>, ContagemPositivoSomaNegativoEntradaValidation>();
            services.AddTransient<IValidator<AutomacaoEntrada>, AutomacaoEntradaValidation>();
            services.AddTransient<IValidator<EnderecoEntrada>, EnderecoEntradaValidation>();
            #endregion


            #region Injeções de repositorio
            services.AddScoped<IAutomacaoRepositorio, AutomacaoRepositorio>();
            #endregion
        }
    }
}
