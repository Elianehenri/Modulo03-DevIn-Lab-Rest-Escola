using Banda.Domain.Interfaces.Repositories;
using Banda.Domain.Interfaces.Services;
using Banda.Domain.Services;
using Banda.Infra.DataBase;
using Banda.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace Banda.DI.DI
{
    public static class DI
    {
        public static IServiceCollection Register(this IServiceCollection builder)
        {
            return builder
                .AddDbContext<BandaDBContexto>()
                .AddScoped<ITocarRepositorio, TocarRepositorio>()
                .AddScoped<ITocarService, TocarServices>()
                .AddScoped<ITocarPostService, TocarPostServices>();
        }
    }
}
