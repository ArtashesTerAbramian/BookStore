using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.DAL;

public static class AddDbContextExtenstion
{
    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("BookStore"), x =>
                        {
                            x.MigrationsHistoryTable("ef_migration_history");
                        })
                    .UseSnakeCaseNamingConvention());
    }
}