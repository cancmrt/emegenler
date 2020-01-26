using Guard.Emegenler.Claims;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Guard.Emegenler.Services.General
{
    public static class GeneralServices
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IEmegenlerUWork, EmegenlerUWork>();
            services.AddScoped<IEmegenlerFluentApi, FluentApi>();
            services.AddScoped<IEmegenlerClaims, EmegenlerClaims>();
        }
    }
}
