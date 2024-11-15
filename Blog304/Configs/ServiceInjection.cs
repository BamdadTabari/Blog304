﻿using DataProvider.Base.Services;
using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Repository;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
namespace Blog304.Configs;

public static class ServiceInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {

        // Add services to the container.
        services.AddControllersWithViews();
        services.AddRazorPages();
        // register an HttpClient that points to itself
        services.AddSingleton(sp =>
        {
            // Get the address that the app is currently running at
            var server = sp.GetRequiredService<IServer>();
            var addressFeature = server.Features.Get<IServerAddressesFeature>();
            var baseAddress = addressFeature?.Addresses.First();
            return new HttpClient { BaseAddress = new Uri(baseAddress ?? "http://localhost") };
        });
        services.AddSingleton<BaseUrlService>();
        services.AddScoped<IHttpService, HttpService>();

        services.AddDbContext<AppDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("ServerDbConnection"))
          .EnableDetailedErrors());

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}