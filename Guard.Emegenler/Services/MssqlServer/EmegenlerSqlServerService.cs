using Guard.Emegenler.DAL;
using Guard.Emegenler.Options;
using Guard.Emegenler.Services.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.MssqlServer
{
    public static class EmegenlerSqlServerService
    {
        /// <summary>
        /// Adding Emegenler table structre to Mssql Database
        /// </summary>
        /// <param name="services">Service collection extension</param>
        /// <param name="SqlServerConnectionString">Mssql server connection string</param>
        /// <param name="GuardOptions">Emegenler Options for unclassified access management</param>
        /// <returns></returns>
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
