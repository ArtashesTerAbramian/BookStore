using System.Reflection;
using BookStore.BLL.Helpers;
using BookStore.BLL.Models;
using BookStore.BLL.Services.AdminService;
using BookStore.BLL.Services.BookService;
using BookStore.BLL.Services.ErrorService;
using BookStore.BLL.Validators.AdminValidators;
using BookStore.DTO.AdminDtos;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.BLL;

public static class ServiceExtention
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(ServiceExtention).Assembly);
        services.Configure<AuthOptions>(options => configuration.GetSection(nameof(AuthOptions)).Bind(options));

        services.AddScoped<ErrorHelper>();
        services.AddScoped<IErrorService, ErrorService>();
        services.AddScoped<IAdminService, AdminService>();
        services.AddScoped<IAdminSessionService, AdminSessionService>();
        services.AddScoped<IBookService, BookService>();

    }
}