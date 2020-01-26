using Guard.Emegenler.DAL;
using Guard.Emegenler.Options;
using Guard.Emegenler.Services.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.MssqlServer
{
    public static class EmegenlerSqlServerService
    {
        public static IServiceCollection AddEmegenlerToSqlServer(this IServiceCollection services, string SqlServerConnectionString, EmegenlerOptions GuardOptions)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseSqlServer(SqlServerConnectionString,
                                                                x => x.MigrationsHistoryTable("__EmegenlerMigrationsHistory", "Emegenler-Guard")));//orginal line
            services.AddSingleton(GuardOptions);

            GeneralServices.Inject(services);

            return services;
        }
        
    }
}
