using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plagecon.Models.Interfaces;
using Plagecon.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plagecon
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
            services.AddSingleton<IBlogRepository, BlogRepository>(); //basicamente chama o framework de dependencia de inje��o e diz, hey, sempre que voc� encontrar o IblogRepository, crie e injete o objeto BlogRepository
            //services.AddScoped<IBlogRepository, BlogRepository>();
            //services.AddTransient<IBlogRepository, BlogRepository>();

            services.AddControllersWithViews();

            /*
             * Transient--> isso chama a nossa aplica��o, ao inv�s do framework de depend�ncia de inje��o, que sempre que voc� encontrar Iblogrepository, sempre crie um novo objeto e injete ele
             * Scope--> se quando chamar o IBlogRepository, se j� existir o objeto e der para usar parte dele, reuse, caso contr�rio crie um novo objeto. Suponhamos que estamos a fazer uma nova requisi��o http esse blog repository � usado 3 vezes em sua �nica aplica��o de request, ent�o o blog repository ser� reutilizado
             * Singleton --> crie esse objeto e mantenha ele sempre e sempre que encontrar o IblogRepository e mantenha ele usando um objeto existente
             */ 
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
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
