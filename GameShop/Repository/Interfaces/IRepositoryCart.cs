using GameShopModel.Entities;

namespace GameShop.Repository.Interfaces;

public interface IRepositoryCart
{
    IEnumerable<GameProduct> GetProducts();
    decimal SumProduct { get; }
    void Add(GameProduct gameProduct);
    void Delete(int id);
    void Clear();
}