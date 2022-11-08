using DestinosApi.Database;
using DestinosApi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.


        var connectionMySql = builder.Configuration.GetConnectionString("ConnectionMySQL");
        builder.Services.AddDbContext<DestinoDbContext>(
            options => options.UseMySql(connectionMySql,
            ServerVersion.Parse("8.0.31-mysql"))
        );

        builder.Services.AddScoped<IDestinoRepository, DestinoRepository>();




        builder.Services.AddControllers();
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