using Blockchat.Areas.Identity.Data;
using Microsoft.AspNetCore.SignalR;

namespace Blockchat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
