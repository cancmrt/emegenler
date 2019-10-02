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
        public static IServiceCollection AddEmegenlerToSqlServer(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<EmegenlerDbContext>(options);
            services.AddScoped<IEmegenlerAuth, EmegenlerAuth>();
            return services;
        }
    }
}
