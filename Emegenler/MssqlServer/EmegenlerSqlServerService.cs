using Emegenler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSource.MssqlServer
{
    public static class EmegenlerSqlServerService
    {
        public static IServiceCollection AddEmegenlerToSqlServer(this IServiceCollection services, string SqlServerConnectionString)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseSqlServer(SqlServerConnectionString));
            services.AddScoped<IEmegenlerAuth, EmegenlerAuth>();
            
            return services;
        }
        
    }
}
