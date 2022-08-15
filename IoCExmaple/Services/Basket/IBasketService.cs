namespace IoCExmaple.Services.Basket
{
    public interface IBasketService
    {
        IList<string> AddBasketItems(List<string> items);
    }
}
