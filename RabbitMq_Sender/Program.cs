// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;
using System.Text;

var connFactory = new ConnectionFactory();
connFactory.HostName = "127.0.0.1";
connFactory.DispatchConsumersAsync = true;//异步分发客户
var connection = connFactory.CreateConnection();
string exchangeName = "exchange1";
while (true)
{
    using var channel = connection.CreateModel();//创建信道
    var prop=channel.CreateBasicProperties();
    prop.DeliveryMode = 2;//消息持久化
    channel.ExchangeDeclare(exchangeName, "direct");
    byte[] btys = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
    channel.BasicPublish(exchangeName, routingKey: "key1", mandatory: true, prop, btys);
    Console.WriteLine("ok"+DateTime.Now);
    Thread.Sleep(1000);
}
