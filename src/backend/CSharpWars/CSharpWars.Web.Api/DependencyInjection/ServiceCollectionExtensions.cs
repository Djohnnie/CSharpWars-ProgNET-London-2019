using System.IO;
using System.Reflection;
using CSharpWars.Common.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CSharpWars.Logic.DependencyInjection;

namespace CSharpWars.Web.Api.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureWebApi(this IServiceCollection services)
        {
            services.ConfigureCommon();
            services.ConfigureLogic();
            services.AddMemoryCache();
            services.AddMvc();
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
        }
    }
}