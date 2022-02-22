using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

//消费者的绑定
var connFactory = new ConnectionFactory();
connFactory.HostName = "127.0.0.1";
connFactory.DispatchConsumersAsync = true;//异步分发客户
var connection = connFactory.CreateConnection();
string exchangeName = "exchange1";
string routingKey = "key1";
string queueName = "queue1";
var channel=connection.CreateModel();
channel.ExchangeDeclare(exchangeName,"direct");
channel.QueueDeclare(queueName,durable:true,exclusive:false,autoDelete:false,arguments:null);
channel.QueueBind(queueName,exchange: exchangeName, routingKey: routingKey);

AsyncEventingBasicConsumer consumer = new AsyncEventingBasicConsumer(channel);
consumer.Received += Consumer_Received;
channel.BasicConsume(queueName, false, consumer: consumer);
Console.WriteLine("按回车退出");
Console.ReadLine();
//rabbitmq 拥有消息的确认机制 ack，解决消费者开始接收消息但是在处理的过程中，出现异常，没有处理成功，导致这条消息丢失了。
async Task Consumer_Received(object sender, BasicDeliverEventArgs @event)
{
    try
    {
        byte[] body = @event.Body.ToArray();
        string str = Encoding.UTF8.GetString(body);
        Console.WriteLine("接受的消息" + DateTime.Now + "," + str);
        channel.BasicAck(@event.DeliveryTag, multiple: false);
        await Task.Delay(800);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        channel.BasicReject(@event.DeliveryTag, true);
    }
}