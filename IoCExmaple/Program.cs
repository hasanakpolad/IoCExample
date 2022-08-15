using IoCExmaple.Services.Basket;
using IoCExmaple.Services.Logger;
using IoCExmaple.Services.Payment;
using IoCExmaple.Services.Validation;
using IoCExmaple.SomeBusinesses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IValidationService, ValidationService>();
builder.Services.AddSingleton<ILoggerService, LoggerService>();

builder.Services.AddTransient<IBasketService, BasketService>();

builder.Services.AddTransient<IPaymentService, PaymentService>();

builder.Services.AddTransient<SomeBusiness>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
