using Microsoft.AspNetCore.SignalR;

namespace chat_application_1.ChatHub
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
