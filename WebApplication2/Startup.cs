using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Startup
    {//stage line
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //stage line
        public IConfiguration Configuration { get; }
        //stage line
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {//stage line
            services.AddRazorPages();
            services.AddRazorPages();
            services.AddRazorPages();
            services.AddRazorPages();
            services.AddRazorPages();
        }
        //stage line
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
          //stage line
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
        //stage line
            app.UseAuthorization();
            //1234
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
