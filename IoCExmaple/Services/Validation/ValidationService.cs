using IoCExmaple.Services.Logger;

namespace IoCExmaple.Services.Validation
{
    public class ValidationService : IValidationService
    {
        ILoggerService _logger;
        public ValidationService(ILoggerService logger)
        {
            Console.WriteLine("ValidationService oluşturuldu :)");

            _logger = logger;
        }
        public void Validate()
        {
            _logger.Info("Validate işlemi yapıldı.");
        }
    }
}
