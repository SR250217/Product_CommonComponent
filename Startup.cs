using System.IO;
using Dodos.UI.Helpers.ExceptionHandler;
using Dodos.UI.Models;
using Dodos.UI.Repositories;
using Dodos.UI.Repositories.Imp;
using Dodos.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Dodos.UI
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
            var connectionString = @"server=192.168.1.100; database=Dodos_reloaded; uid=dodos_users; pwd=Welcome2018;";
            services.AddMvc();
            services.AddDbContext<MyBloggingContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<Loginservices, Loginservices>();
            services.AddScoped<ILogin, LoginImp>();

            services.AddDbContext<MyBackupBloggingContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<Common_Connectionservices, Common_Connectionservices>();
            services.AddScoped<ICommon_Connection, Common_ConnectionIMP>();
            services.AddScoped<Countriesservices, Countriesservices>();
            services.AddScoped<ICountries, CountriesImp>();
            services.AddScoped<Statesservices, Statesservices>();
            services.AddScoped<IStates, StatesImp>();
            services.AddScoped<Citiesservices, Citiesservices>();
            services.AddScoped<ICities, CitiesImp>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/Dodos.UI-{Date}.txt");

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseAuthentication();
            app.UseMvc();
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html";
                await context.Response.SendFileAsync(Path.Combine(env.WebRootPath, "index.html"));
            });
        }
    }
}