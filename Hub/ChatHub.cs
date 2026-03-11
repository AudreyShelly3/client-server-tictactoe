using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;


namespace SignlaR.Hubs
{ 
    public class ChatHub : Hub
    {  
        
        public async Task SendString
            (string Message)
        {
            await Clients.All.SendAsync("ReceiveString", Message); 
        } 
    }

    

    public class NotificationHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task SendString
            (string Message)
        {
            await Clients.All.SendAsync("ReceiveString", Message);
        }
    } 
}
