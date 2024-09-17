using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_Session_1.Data;
using MVC_Session_1.Interfaces;
using MVC_Session_1.Repositories;

namespace MVC_Session_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
            builder.Services.AddScoped<IStudentRepo, StudentRepo>();
            builder.Services.AddScoped<ICourseRepo, CourseRepo>();
            builder.Services.AddDbContext<CollegeContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncection"));
            });
            builder.Services.AddSession(x =>
            {
                x.Cookie.Name = "User";
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Student}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
