using SignalR.Hubs;

namespace SignalRDemo.SignalR
{
    [HubName("blogHub")]
    public class BlogHub : Hub
    {
        public void Send(string message, string sessionId) {
            Clients.addMessage(message, sessionId);
        }    
    }
}