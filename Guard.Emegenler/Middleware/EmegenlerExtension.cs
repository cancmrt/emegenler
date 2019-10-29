using Guard.Emegenler.DAL;
using Guard.Emegenler.Middleware.EmegenlerMiddleaware;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Middleware
{
    public static class EmegenlerExtension
    {
        public static IApplicationBuilder UseEmegenler(this IApplicationBuilder applicationBuilder)
        {
            IServiceProvider serviceProvider = applicationBuilder.ApplicationServices;
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EmegenlerDbContext>();
                // auto migration
                context.Database.Migrate();
            }
            return applicationBuilder.UseMiddleware<GuardMiddleware>();

        }
    }
}
