﻿namespace Lab1
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"{user}: {message}");

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
