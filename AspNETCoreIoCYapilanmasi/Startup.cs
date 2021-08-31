using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNETCoreIoCYapilanmasi.Services;
using AspNETCoreIoCYapilanmasi.Services.Interface;

namespace AspNETCoreIoCYapilanmasi
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
            services.AddControllersWithViews();
            // services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog())); Default olarak Add ile eklenirse Singleton davranýþýdýr.
            // services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));
            
            // services.AddSingleton<ConsoleLog>(); // parametre alan bir constructer ise bu kullanýlmaz/davranýþý sergileyemez 
            // services.AddSingleton<ConsoleLog>(p=>new ConsoleLog(5)); //parametre alan bir constructer ise bu kullanýlabilir.

            // services.AddScoped<ConsoleLog>();
            // services.AddScoped<ConsoleLog>(p=>new ConsoleLog(4));

            // services.AddTransient<ConsoleLog>();
           //  services.AddTransient<ConsoleLog>(p=>new ConsoleLog(3));

           //services.AddScoped<ILog>(p => new ConsoleLog(5)); 
           services.AddScoped<ILog, TextLog>();


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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
