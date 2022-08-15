using IoCExmaple.Services.Logger;

namespace IoCExmaple.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        ILoggerService logger;
        public PaymentService(ILoggerService _logger)
        {
            Console.WriteLine("Payment Service oluşturuldu :)");

            logger = _logger;
        }
        public void Payment()
        {
            logger.Info("Ödeme işlemi");
        }
    }
}
