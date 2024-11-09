namespace Lab1
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Log message on the server console
            Console.WriteLine($"{user}: {message}");

            // Optionally, send the message back to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
