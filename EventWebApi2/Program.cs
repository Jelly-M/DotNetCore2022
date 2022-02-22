using System.Reflection;
using Zack.EventBus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//定义消费者，配置
builder.Services.Configure<IntegrationEventRabbitMQOptions>(t =>
{
    t.HostName = "127.0.0.1";
    t.ExchangeName = "exchangeEventBusDemo1";
});
builder.Services.AddEventBus("queue1", Assembly.GetExecutingAssembly());
var app = builder.Build();
//定义消费者，配置
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
