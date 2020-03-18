using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculatrice.Services;
using Calculatrice.Services.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Calculatrice
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
            services.AddSingleton(
                typeof(OperationService), // Si tu as besoin d'un Object Service de type ...
                typeof(OperationCalculatriceService) // Tu creer un singleton de type....
            );
            // 3 je dis au framework que si je demande un UtilisateurService il doit me renvoyer une instance de UtilisateurCalculatriceService
            services.AddSingleton(typeof(UtilisateurService), typeof(UtilisateurCalculatriceService));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
