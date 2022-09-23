using Escola.Domain.Interfaces.Repositories;
using Escola.Infra.DataBase.Repositories;

namespace Escola.Api.Config.Ioc
{
    public class RepositoryIoC
    {
        public static void RegisterServices(IServiceCollection builder)
        {
            builder.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
        }
    }
}
