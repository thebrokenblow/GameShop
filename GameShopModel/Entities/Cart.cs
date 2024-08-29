namespace GameShopModel.Entities;

public class Cart
{
    public int Id { get; set; }
    public required User User { get; set; }
    public required List<GameProduct> GameProducts { get; set; }
    public required decimal SumProduct { get; set; }
}