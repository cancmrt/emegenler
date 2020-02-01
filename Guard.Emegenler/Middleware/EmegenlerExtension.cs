using Guard.Emegenler.DAL;
using Guard.Emegenler.Middleware.EmegenlerMiddleaware;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Guard.Emegenler.Middleware
{
    public static class EmegenlerExtension
    {
        /// <summary>
        /// Extend your application builder auto migrate options from emegenler and assign middleware
        /// </summary>
        /// <param name="applicationBuilder">Application builder</param>
        /// <returns>Configurated ApplicationBuilder</returns>
        public static IApplicationBuilder UseEmegenler(this IApplicationBuilder applicationBuilder)
        {
            IServiceProvider serviceProvider = applicationBuilder.ApplicationServices;
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EmegenlerDbContext>();
                if (context.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                {
                    context.Database.Migrate();
                }
            }
            return applicationBuilder.UseMiddleware<GuardMiddleware>();

        }
    }
}
