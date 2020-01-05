using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Logfiks.DataAccess.Abstract;
using Logfiks.DataAccess.Concrete.EntityFramework;
using Logfiks.Middleware;
using Logfiks.Models;
using LogFiks.Business.Abstract;
using LogFiks.Business.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SoapCore;

namespace Logfiks
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILogfiksService, LogfiksService>();

            services.AddScoped<ITasitTipiService, TasitTipiManager>();
            services.AddScoped<ITasitTipiDal, EfTasitTipiDal>();

            services.AddScoped<IApiKullanicilariService, ApiKullanicilariManager>();
            services.AddScoped<IApiKullanicilariDal, EfApiKullanicilariDal>();



            services.AddDistributedMemoryCache();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSoapCore();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSoapEndpoint<ILogfiksService>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseHttpsRedirection();


            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IApiKullanicilariService>();

                app.UseWhen(x => (x.Request.Path.StartsWithSegments("/RestApi", StringComparison.OrdinalIgnoreCase)), builder => { builder.UseMiddleware<AuthenticationMiddleware>(); });
            }



            


            // app.UseMiddleware<AuthenticationMiddleware>();
            app.UseMvc();

        }
    }
}
