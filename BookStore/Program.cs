using BookStore.BLL;
using BookStore.BLL.Helpers;
using BookStore.BLL.Validators.AdminValidators;
using BookStore.DAL;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
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
    
    builder.Services.AddControllers()
        .AddFluentValidation(options => 
            options.RegisterValidatorsFromAssembly(typeof(AddAdminValidator).Assembly));



    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
    });


    
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
        {
            Description = "ApiKey must appear in header",
            Type = SecuritySchemeType.ApiKey,
            Name = "Authorization",
            In = ParameterLocation.Header,
            Scheme = "ApiKeyScheme"
        });
        var key = new OpenApiSecurityScheme()
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "ApiKey"
            },
            In = ParameterLocation.Header
        };
        var requirement = new OpenApiSecurityRequirement
        {
            { key, new List<string>() }
        };
        c.AddSecurityRequirement(requirement);
    });
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

    app.UseAuthentication();
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