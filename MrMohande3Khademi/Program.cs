
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MrMohande3Khademi.DAL;
using MrMohande3Khademi.Services;
using MrMohande3Khademi.SwaggerConfig;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MrMohande3Khademi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen(config => {
            //    config.OperationFilter<HeaderConfig>();
            //});

            builder.Services.AddSwaggerGen(option => new AuthenticationConfig().GetOptions());

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<IAccessControllerService, AccessControllerService>();

            builder.Services.AddDbContext<DatabaseContext>(
                options =>
                {
                    options.UseSqlite(builder.Configuration.GetConnectionString("SQLLiteConnectionString"));
                });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
