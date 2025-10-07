
using Day21WebApiLab.Data;
using Day21WebApiLab.Services.Implements;
using Day21WebApiLab.Services.Interfaces;
using Day21WebApiLab.UnitOfWorks.Implement;
using Day21WebApiLab.UnitOfWorks.Interface;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
namespace Day21WebApiLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mycors = "MyCors";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddControllers();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            //Add DbContext Configuration 
            builder.Services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            //Cors
            builder.Services.AddCors(options =>
            options.AddPolicy(mycors, builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
                //builder.WithMethods("Get", "Put");
                //builder.WithOrigins("www.facebook.com", "www.localhost.com");
            }));
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            //Add Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Resolving Services Repositories 
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(mycors);

            app.MapControllers();

            app.Run();
        }
    }
}
