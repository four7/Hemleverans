using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TomasosPizzeria.Models;

namespace TomasosPizzeria
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
            services.AddMvc(setupAction: i => i.EnableEndpointRouting = false);
            var conn = @"Server=localhost;Database=Tomasos;Trusted_Connection=True;";
            services.AddDbContext<TomasosContext>(options => options.UseSqlServer(conn));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "Default",
                template: "{controller=Home}/{action=Index}"
                    );
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
        }
    }
}
