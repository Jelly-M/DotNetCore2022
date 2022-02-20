using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public class MyHub:Hub
    {
        public Task SendPublicMsg(string msg)
        {
            string connId = this.Context.ConnectionId;
            string msgToSend = $"{connId} {DateTime.Now} :{msg}";
            return this.Clients.All.SendAsync("PublicMsgReceived", msgToSend);  //直接返回时，不需要使用await async
        }
    }
}
