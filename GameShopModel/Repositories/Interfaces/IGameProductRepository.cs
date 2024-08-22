using GameShopModel.Entities;

namespace GameShopModel.Repositories.Interfaces;

public interface IGameProductRepository
{
    public Task<List<GameProduct>> GetAllGameProductsAsync();

    public Task<GameProduct> GetGameProductAsync(int id);

    public Task AddGameProductAsync(GameProduct gameProduct);

    public Task RemoveGameProductAsync(int id);

    public Task EditGameProductAsync(int id, GameProduct gameProduct);
}
