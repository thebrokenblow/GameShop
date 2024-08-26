using GameShopModel.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Controllers;

public class GameController(GameShopContext gameShopContext) : Controller
{
    public async Task<IActionResult> Details(int id)
    {
        var gameProduct = await gameShopContext.GameProducts
            .Include(gameProduct => gameProduct.Genre)
            .Include(gameProduct => gameProduct.ImagesUrl)
            .FirstAsync(gameProduct => gameProduct.Id == id);
       
        return View(gameProduct);
    }
}