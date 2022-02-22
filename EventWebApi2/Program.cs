using System.Reflection;
using Zack.EventBus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//���������ߣ�����
builder.Services.Configure<IntegrationEventRabbitMQOptions>(t =>
{
    t.HostName = "127.0.0.1";
    t.ExchangeName = "exchangeEventBusDemo1";
});
builder.Services.AddEventBus("queue1", Assembly.GetExecutingAssembly());
var app = builder.Build();
//���������ߣ�����
app.UseEventBus();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
