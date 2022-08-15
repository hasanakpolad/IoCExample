using IoCExmaple.Services.Basket;
using IoCExmaple.Services.Logger;
using IoCExmaple.Services.Payment;
using IoCExmaple.Services.Validation;

namespace IoCExmaple.SomeBusinesses
{
    public class SomeBusiness
    {
        private IPaymentService _payment;
        private IBasketService basket;
        private IValidationService validation;
        private ILoggerService loggerService;

        public SomeBusiness(IPaymentService payment, IBasketService _basket, IValidationService _validation, ILoggerService _loggerService)
        {
            _payment = payment;
            basket = _basket;
            validation = _validation;
            loggerService = _loggerService;
            loggerService.Info("SomeBusiness oluşturuldu.");
        }

        public void DoSomePayment()
        {
            _payment.Payment();
            loggerService.Info("some payment işlemi yapıldı");
        }

        public void DoSomeBasket()
        {
            basket.AddBasketItems(new List<string>() { "item1", "item2", "item3" });
            _payment.Payment();
            loggerService.Info("some basket işlemi yapıldı");
        }

        public void DoSomeValidate()
        {
            validation.Validate();
            loggerService.Info("some validate işlemi yapıldı");

        }
    }
}
