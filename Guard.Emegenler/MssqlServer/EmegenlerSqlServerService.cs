using Guard.Emegenler;
using Guard.Emegenler.DAL;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.UnitOfWork;
using Microsoft.AspNetCore.Http;
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

            ///Refactor tips you should seperate this from here, you should use all of them in all version
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IEmegenlerUWork, EmegenlerUWork>();
            services.AddScoped<IFluentApi, FluentApi>();

            return services;
        }
        
    }
}
