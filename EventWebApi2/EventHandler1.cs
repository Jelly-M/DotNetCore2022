using Zack.EventBus;

namespace EventWebApi2
{
    [EventName("OrderCreate")]
    [EventName("OrderDeleted")]
    public class EventHandler1 : IIntegrationEventHandler
    {
        /// <summary>
        /// 接收参数是一个json字符串
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="eventData"></param>
        /// <returns></returns>
        public Task Handle(string eventName, string eventData)
        {
           if(eventName == "OrderCreate")
            {
                Console.WriteLine("收到订单，eventData="+eventData.ToString());
            }
            return Task.CompletedTask;
        }
    }
}
