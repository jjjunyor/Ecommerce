using AVAL.Infrastructure.Repository;
using Domain.Interface.Repository;
using Domain.Interface.Services;
using Domain.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;


namespace WebApp
{ 
    /// <summary>
    /// Classe de configuração raiz.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// definição da variavel global de configuração.
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Configuração principal.
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// COnfigura as interfaces e classes para serem utilizadas.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
        

            services.AddMvc();
            

            services.AddCors(options => { options.AddPolicy("AllowAllOrigins", b => { b.AllowAnyOrigin().AllowCredentials().AllowAnyHeader().AllowAnyMethod(); }); });

            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<AVAL.Infrastructure.Data.AvalContext>(options =>
              options.UseSqlServer(connectionString)
            );

            services.AddTransient<ISegurancaService, SegurancaService>();
            services.AddTransient<IContaService, ContaService>();
            services.AddTransient<IContaRepository, ContaRepository>();

            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<ISegurancaService, SegurancaService>();
            services.AddTransient<ISegurancaRepository, SegurancaRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API Produtos", Version = "v1" });
            });
        

        }
        /// <summary>
        /// metodo chamado em tempo real - pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c =>
                {
                    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
                    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "API CorporateCore");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseCors(option => option.AllowAnyOrigin()); ;
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            

        }
    }
}
