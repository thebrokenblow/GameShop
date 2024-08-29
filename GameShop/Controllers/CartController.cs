using Microsoft.AspNetCore.Mvc;
using GameShop.Repository.Interfaces;
using GameShopModel.Data;
using GameShopModel.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Controllers;

public class CartController(UserManager<User> userManager, GameShopContext gameShopContext, IRepositoryCart repositoryCart) : Controller
{
    public IActionResult Index()
    {
        var products = repositoryCart.GetProducts();
        return View(products);
    }

    public IActionResult Delete(int id)
    {
        repositoryCart.Delete(id);

        return Redirect("/Cart/Index");
    }

    public async Task<IActionResult> PlaceOrder()
    {
        var user = await userManager.FindByEmailAsync("artkrasov@gmail.com");

        if (user is not null)
        {
            
            var gameProduct = gameShopContext.GameProducts.Where(x => x.Id == 2).Include(x => x.Carts).AsNoTracking().First();

            var cart = new Cart
            {
                GameProducts = repositoryCart.GetProducts().ToList(),
                SumProduct = repositoryCart.SumProduct,
                User = user
            };

            gameProduct.Carts.Add(cart);
            await gameShopContext.Carts.AddAsync(cart);
            await gameShopContext.SaveChangesAsync();
        }

        repositoryCart.Clear();

        return Redirect("/Home");
    }
}