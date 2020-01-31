using Guard.Emegenler.DAL;
using Guard.Emegenler.Options;
using Guard.Emegenler.Services.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.InMemoryServer
{
    public static class EmegenlerInMemoryServerService
    {
        /// <summary>
        /// Using Emegenler in InMemory Database
        /// </summary>
        /// <param name="services">Service Collection Extension</param>
        /// <param name="GuardOptions">Emegenler Options for unclassified access management</param>
        /// <returns></returns>
        public static IServiceCollection AddEmegenlerToInMemoryServer(this IServiceCollection services, EmegenlerOptions GuardOptions)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseInMemoryDatabase("EmegenlerInMemory"));//orginal line
            services.AddSingleton(GuardOptions);

            GeneralServices.Inject(services);

            return services;
        }
    }
}
