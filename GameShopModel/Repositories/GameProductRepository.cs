using GameShopModel.Data;
using GameShopModel.Entities;
using GameShopModel.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GameShopModel.Repositories;

public class GameProductRepository(GameShopContext gameShopContext) : IGameProductRepository
{
    public async Task<List<GameProduct>> GetAllGameProductsAsync() =>
        await gameShopContext.GameProducts.ToListAsync();

    public async Task<GameProduct> GetGameProductAsync(int id) =>
        await gameShopContext.GameProducts.FirstAsync(gameProduct => gameProduct.Id == id);

    public async Task AddGameProductAsync(GameProduct gameProduct)
    {
        await gameShopContext.GameProducts.AddAsync(gameProduct);
        await gameShopContext.SaveChangesAsync();
    }

    public async Task RemoveGameProductAsync(int id) =>
        await gameShopContext.GameProducts
        .Where(gameProduct => gameProduct.Id == id)
        .ExecuteDeleteAsync();

    public async Task EditGameProductAsync(int id, GameProduct gameProduct) =>
        await gameShopContext.GameProducts
            .Where(editingGameProduct => editingGameProduct.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(
                    editingGameProduct => editingGameProduct.PresentationImageUrl, gameProduct => gameProduct.PresentationImageUrl)
                .SetProperty(
                    editingGameProduct => editingGameProduct.Title, gameProduct => gameProduct.Title)
                .SetProperty(
                    editingGameProduct => editingGameProduct.Description, gameProduct => gameProduct.Description)
                .SetProperty(
                    editingGameProduct => editingGameProduct.Price, gameProduct => gameProduct.Price)
                .SetProperty(
                    editingGameProduct => editingGameProduct.ReleaseDate, gameProduct => gameProduct.ReleaseDate)
                .SetProperty(
                    editingGameProduct => editingGameProduct.Genre, gameProduct => gameProduct.Genre)
                .SetProperty(
                    editingGameProduct => editingGameProduct.ImagesUrl, gameProduct => gameProduct.ImagesUrl));
}