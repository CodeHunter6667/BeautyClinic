using BeautyClinic.Core.Interfaces;
using BeautyClinic.Infrastructure.Context;
using BeautyClinic.Infrastructure.Repositories;
using BeautyClinic.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace BeautyClinic.Api.Commons;

public static class BuilderExtensions
{
    public static void AddConfigurations(this WebApplicationBuilder builder)
    {
        Configurations.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
    }

    public static void AddDbContext(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(Configurations.ConnectionString,
            ServerVersion.AutoDetect(Configurations.ConnectionString)));
    }

    public static void AddRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
