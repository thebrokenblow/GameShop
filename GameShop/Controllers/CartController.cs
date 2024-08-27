using GameShop.Repository.Interfaces;
using GameShopModel.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers;

public class CartController(IRepositoryCart repositoryCart) : Controller
{
    public IActionResult Index()
    {
        var products = repositoryCart.GetProducts();
        return View(products);
    }

    public async Task<IActionResult> Delete(int id)
    {
        repositoryCart.Delete(id);

        return View("Index", repositoryCart.GetProducts());
    }
}