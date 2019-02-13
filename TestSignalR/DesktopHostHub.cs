using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace TestSignalR.Hubs {
    public class DesktopHostHub : Hub {
        public async Task mymethod(string user , string msg) {
            Console.WriteLine($"Received from client: {user} and msg : {msg}");
            await Clients.All.SendAsync("ReceiveMessage",user,"This is msg from DesktopHost Hub.");
        } 
    }
}