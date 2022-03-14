using CancerDeMama.Application.Interfaces;
using CancerDeMama.Application.Services;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Domain.Core.Interfaces.Services;
using CancerDeMama.Domain.Core.Services;
using CancerDeMama.Infra.Data.Contexts;
using CancerDeMama.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


namespace CancerDeMama.Api
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

            services.AddDbContext<CancerDeMamaContext>(
                context => context.UseSqlServer(Configuration.GetConnectionString("CancerMama"))
            );
            services.AddControllers();

            #region Injeção de referência
            services.AddScoped<IRegiaoAppService, RegiaoAppService>();
            services.AddScoped<IRegiaoService, RegiaoService>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();

            services.AddScoped<IFaixaEtariaAppService, FaixaEtariaAppService>();
            services.AddScoped<IFaixaEtariaService, FaixaEtariaService>();
            services.AddScoped<IFaixaEtariaRepository, FaixaEtariaRepository>();

            services.AddScoped<IIncidenciaExameAppService, IncidenciaExameAppService>();
            services.AddScoped<IIncidenciaExameService, IncidenciaExameService>();
            services.AddScoped<IIncidenciaExameRepository, IncidenciaExameRepository>();

            #endregion


            #region Manipulação do Loop de Referência - instalar package Microsoft.AspNetCore.Mvc.NewtonsoftJson 
            services.AddControllersWithViews()
                                            .AddNewtonsoftJson(options =>
                                            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            #endregion

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CancerDeMama.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CancerDeMama.Api v1"));
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
