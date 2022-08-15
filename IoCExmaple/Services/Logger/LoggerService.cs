namespace IoCExmaple.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
            Console.WriteLine("Logger oluşturuldu :)");
        }
        public void Info(string message)
        {
            Console.WriteLine(message);

        }
    }
}
