using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Business.Concrete;
using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.DataAccess.Concrete;
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

namespace KaleAkvaryum.MvcWebUi
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
            services.AddControllersWithViews();
            services.AddControllersWithViews();
            services.AddSingleton<IFishBs, FishBs>();
            services.AddSingleton<IFishRepository, FishRepository>();
            services.AddSingleton<IManagerBs, ManagerBs>();
            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddSingleton<ITbalikBs, TbalikBs>();
            services.AddSingleton<ITbalikRepository, TbalikRepository>();
            services.AddSingleton<IBlogBs, BlogBs>();
            services.AddSingleton<IBlogRepository, BlogRepository>();

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "blog-photo-upload",
                  defaults: new { controller = "Blog", action = "PhotoUpload" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "new-blog",
                  defaults: new { controller = "Blog", action = "New" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "blog-list",
                  defaults: new { controller = "Blog", action = "Index" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "type-list",
                  defaults: new { controller = "Tbalik", action = "Index" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "new-type",
                  defaults: new { controller = "Tbalik", action = "New" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "new-fish",
                  defaults: new { controller = "Fish", action = "New" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "fish-photo-upload",
                  defaults: new { controller = "Fish", action = "PhotoUpload" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "fish-list",
                  defaults: new { controller = "Fish", action = "Index" }
                  );
                endpoints.MapAreaControllerRoute(
                  name: "adminLogin",
                  areaName: "AdminPanel",
                  pattern: "admin-dashboard",
                  defaults: new { controller = "Dashboard", action = "Index" }
                  );
                endpoints.MapAreaControllerRoute(
                   name: "adminLogin",
                   areaName: "AdminPanel",
                   pattern: "admin",
                   defaults: new { controller = "Manager", action = "Login" }
                   );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
