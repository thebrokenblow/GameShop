using GameShopModel.Data;
using GameShopModel.Repositories.Interfaces;
using GameShopModel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameShop;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        //services.AddTransient<IGameProductRepository, GameProductRepository>();
        //services.AddControllersWithViews();
        //services.AddDbContext<GameShopContext>(options =>
        //        options.UseSqlServer(builder.Configuration.GetConnectionString("GameShopContext") ??
        //        throw new InvalidOperationException("Connection string 'GameShopContext' not found.")));
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
    }
}
