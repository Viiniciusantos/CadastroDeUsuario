using App.TailorIT.Application.AppServices;
using App.TailorIT.Application.Interfaces;
using App.TailorIT.Domain.Interfaces;
using App.TailorIT.Domain.Services;
using App.TailorIT.Infra.Data.Context;
using App.TailorIT.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace App.TailorIT.Infra.IoC
{
    public static class Bootstrapper
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<TailorITContext>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<ISexoAppService, SexoAppService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ISexoService, SexoService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ISexoRepository, SexoRepository>();

            return services;
        }
    }
}
