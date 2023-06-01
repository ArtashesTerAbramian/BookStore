using System.Reflection;
using BookStore.BLL;
using BookStore.BLL.Helpers;
using BookStore.DAL;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.FromLogContext()
        .CreateLogger();
    builder.Host.UseSerilog(Log.Logger);

    builder.Services.AddDbContext(builder.Configuration);
    
    builder.Services.AddControllers().AddFluentValidation();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddFluentValidationRulesToSwagger();
    
    builder.Services.AddServices(builder.Configuration);
    
    builder.Services.AddAuthentication("CustomAuth")
        .AddScheme<AuthenticationSchemeOptions, CustomAuthenticationHandler>("CustomAuth", null);

    
    var app = builder.Build();

    await app.DatabaseMigrate();
    app.UseSerilogRequestLogging();

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
catch (Exception ex)
{
    Log.Warning(ex, "An error occurred starting the application");
}
finally
{
    Log.CloseAndFlush();
}