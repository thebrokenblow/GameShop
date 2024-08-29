using GameShopModel.Data;
using GameShopModel.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers;

public class LibraryController(GameShopContext gameShopContext, UserManager<User> userManager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var user = await userManager.FindByEmailAsync("artkrasov@gmail.com");

        return View();
    }
}
