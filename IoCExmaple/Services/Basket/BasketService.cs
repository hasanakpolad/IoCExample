using IoCExmaple.Services.Logger;

namespace IoCExmaple.Services.Basket
{
    public class BasketService : IBasketService
    {
        ILoggerService _logger;
        List<string> basketItems = new List<string>();
        public BasketService(ILoggerService logger)
        {
            Console.WriteLine("Basket Service oluşturuldu :)");
            _logger = logger;
        }

        public IList<string> AddBasketItems(List<string> items)
        {
            basketItems.AddRange(items);

            Console.WriteLine(string.Join(',', basketItems));

            _logger.Info("Sepete ekleme işlemi");
            return basketItems;

        }
    }
}
