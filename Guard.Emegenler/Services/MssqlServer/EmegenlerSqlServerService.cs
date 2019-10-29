﻿using Guard.Emegenler;
using Guard.Emegenler.DAL;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.Services.General;
using Guard.Emegenler.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Services.MssqlServer
{
    public static class EmegenlerSqlServerService
    {
        public static IServiceCollection AddEmegenlerToSqlServer(this IServiceCollection services, string SqlServerConnectionString)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseSqlServer(SqlServerConnectionString));

            GeneralServices.Inject(services);

            return services;
        }
        
    }
}