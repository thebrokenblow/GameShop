using GameShopModel.Data;
using GameShopModel.Repositories.Interfaces;
using GameShopModel.Repositories;
using Microsoft.EntityFrameworkCore;
using GameShop.Repository.Interfaces;
using GameShop.Repository;
using GameShopModel.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GameShop;

public class Startup(IConfiguration configuration)
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IGameProductRepository, GameProductRepository>();
        services.AddSingleton<IRepositoryCart, RepositoryCart>();
        services.AddControllersWithViews();
        services.AddDbContext<GameShopContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GameShopContext") ??
                throw new InvalidOperationException("Connection string 'GameShopContext' not found.")));

        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<GameShopContext>();
        services.AddMemoryCache();
        services.AddSession();
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        //Seed.SeedUsersAndRolesAsync(app);
    }
}
