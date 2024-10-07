using Microsoft.EntityFrameworkCore;
using ProfessionalGYM.AppDb;
using System;
namespace ProfessionalGYM
{

    public class program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
            builder.Services.AddDbContext<GymDB>(options =>
            options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddDbContext<GymDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

            builder.Services.AddControllers();
          //  builder.Services.AddCustomServices();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}