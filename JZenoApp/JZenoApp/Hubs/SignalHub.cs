using JZenoApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace JZenoApp.Hubs
{
    public class SignalHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
