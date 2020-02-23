

using Guard.Emegenler.DAL;
using Guard.Emegenler.Options;
using Guard.Emegenler.Services.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.SqliteServer
{
    public static class EmegenlerSqliteServerService
    {
        /// <summary>
        /// Adding Emegenler table structre to Mssql Database
        /// </summary>
        /// <param name="services">Service collection extension</param>
        /// <param name="SqlServerConnectionString">Sqlite server connection string</param>
        /// <param name="GuardOptions">Emegenler Options for unclassified access management</param>
        /// <returns></returns>
        public static IServiceCollection AddEmegenlerToSqlServer(this IServiceCollection services, string SqlServerConnectionString, EmegenlerOptions GuardOptions)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseSqlite(SqlServerConnectionString,
                                                                x => x.MigrationsHistoryTable("__EmegenlerMigrationsHistory", "Emegenler-Guard")));//orginal line
            services.AddSingleton(GuardOptions);

            GeneralServices.Inject(services);

            return services;
        }
    }
}
