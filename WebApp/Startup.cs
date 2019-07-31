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
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<AVAL.Infrastructure.Data.AvalContext>(options =>
              options.UseSqlServer(connectionString)
            );
            //feito para gerar as tabelas identity.
            //services.AddDbContext<AVAL.Infrastructure.Data.TokenContext>(options =>
            //    options.UseSqlServer(connectionString)
            //);

        //    services.AddDefaultIdentity<IdentityUser>()
        //.AddDefaultUI(UIFramework.Bootstrap4)
        //.AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddTransient<IContaService, ContaService>();
            services.AddTransient<IContaRepository, ContaRepository>();

            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API Banco Aval", Version = "v1" });
            });
    
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Banco Aval9");
            });

            app.UseMvc();
        }
    }
}
