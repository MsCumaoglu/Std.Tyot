using Core.Interfaces;
using BLL.Services;
using Core.Interfaces.IServices;
using Core.Models;
using Dal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace Web.UI.Mvc.Core
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

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped(typeof(IExamService), typeof(ExamService));
            services.AddScoped(typeof(IUniverstyService), typeof(UniversityService));
            services.AddScoped(typeof(IFacultyService), typeof(FacultyService));
            services.AddScoped(typeof(ICityService), typeof(CityService));



            services.AddDbContext<TyottrContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlConStr")
                //    ,o=>
                //{
                //    o.MigrationsAssembly("Std.Tyot.Dal");
                //}
                );
            });

            services.AddControllersWithViews();
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
