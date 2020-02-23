using System;
using EmegenlerMvcPlayground.Context;
using Guard.Emegenler.Middleware;
using Guard.Emegenler.Options;
using Guard.Emegenler.Options.DefaultBehaviours;
using Guard.Emegenler.Services.SqliteServer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmegenlerMvcPlayground
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddDbContext<PlaygroundContext>(options => options.UseSqlite("Data Source="+ AppDomain.CurrentDomain.BaseDirectory + "EmegenlerTryDB.db;"));
            services.AddEmegenlerToSqliteServer("Data Source="+ AppDomain.CurrentDomain.BaseDirectory + "EmegenlerTryDB.db;",
                new EmegenlerOptions
                {
                    PageAccessDeniedUrl = "/home/accessdenied",
                    ComponentDefaultBehaviour = ComponentDefaultBehaviour.Hide,
                    FormDefaultBehaviour = FormDefaultBehaviour.Hide

                }


            );
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.Name = "cc";
                    options.LoginPath = "/auth/login";
                    options.LogoutPath = "/auth/logout";
                    options.ExpireTimeSpan = TimeSpan.FromDays(5);
                    options.SlidingExpiration = false;
                });

            services.AddControllersWithViews();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEmegenler();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            using(var service = app.ApplicationServices.CreateScope())
            {
                var context =  service.ServiceProvider.GetService<PlaygroundContext>();
                context.Database.Migrate();
            }
        }
    }
}
