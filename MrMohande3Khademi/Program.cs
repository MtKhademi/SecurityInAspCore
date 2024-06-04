
using Microsoft.EntityFrameworkCore;
using MrMohande3Khademi.DAL;

namespace MrMohande3Khademi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
