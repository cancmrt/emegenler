using Guard.Emegenler.DAL;
using Guard.Emegenler.Options;
using Guard.Emegenler.Services.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.InMemoryServer
{
    public static class EmegenlerInMemoryServerService
    {
        public static IServiceCollection AddEmegenlerToInMemoryServer(this IServiceCollection services, EmegenlerOptions GuardOptions)
        {
            services.AddDbContext<EmegenlerDbContext>(options => options.UseInMemoryDatabase("EmegenlerInMemory"));//orginal line
            services.AddSingleton(GuardOptions);

            GeneralServices.Inject(services);

            return services;
        }
    }
}
