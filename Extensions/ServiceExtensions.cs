using TaskManagementSystem.Api.Services;
using TaskManagementSystem.Api.Repositories;
using TaskManagementSystem.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("YourConnectionString"));

            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IReportService, ReportService>();

            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();
        }
    }
}
