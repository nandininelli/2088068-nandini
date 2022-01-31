using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using DoctorsManagement.Models;
using Microsoft.Extensions.Logging;

namespace DoctorsManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services,ILoggerFactory logger)
        {
            services.AddControllersWithViews();
          
            var conn = Configuration.GetConnectionString("con");


            services.AddDbContext<DoctorsDbContext>(setup => setup.UseSqlServer(conn));
            services.AddScoped<IRepository<DoctorsInfo>, GenericRepository<DoctorsInfo>>();
            services.AddSingleton(logger).AddLogging();
           
               

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
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
            loggerFactory.AddLog4Net();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Doctors}/{action=Index}/{id?}");
            });
        }
    }
}
