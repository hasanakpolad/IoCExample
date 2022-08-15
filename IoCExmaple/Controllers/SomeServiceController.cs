using IoCExmaple.Services.Basket;
using IoCExmaple.Services.Logger;
using IoCExmaple.Services.Payment;
using IoCExmaple.Services.Validation;
using IoCExmaple.SomeBusinesses;
using Microsoft.AspNetCore.Mvc;

namespace IoCExmaple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeServiceController : ControllerBase
    {
        private IPaymentService payment;
        private IBasketService basket;
        private IBasketService basketService;
        private IValidationService validation;
        private ILoggerService loggerService;
        private SomeBusiness someBusiness;
        public SomeServiceController(IPaymentService _payment, IBasketService _basket, IValidationService _validation, ILoggerService _loggerService, SomeBusiness _someBusiness, IBasketService _basketService)
        {
            payment = _payment;
            basket = _basket;
            validation = _validation;
            loggerService = _loggerService;
            someBusiness = _someBusiness;
            basketService = _basketService;
        }
        [HttpGet(nameof(GetSomeService))]
        public IActionResult GetSomeService()
        {
            bool res = basket == basketService;
            basket.AddBasketItems(new List<string>() { "itemInContr", "itemInContr2", "itemInContr3" });
            basketService.AddBasketItems(new List<string>() { "itemInContr4", "itemInContr5", "itemInContr6" });
            //someBusiness.DoSomeBasket();
            //someBusiness.DoSomeValidate();
            //someBusiness.DoSomePayment();
            loggerService.Info("Controllerdan istek geldi");
            return Ok();
        }

    }
}
