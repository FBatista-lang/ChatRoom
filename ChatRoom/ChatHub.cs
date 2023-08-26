using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class ChatHub : Hub 
    {
        public async Task SendMessage(string room, string user, string message)
        {
            //Enviamos un mensaje de forma asincrona a un grupo determinado
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddToGroup(string room)
        {
            //Añadimos a la persona a la sala
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            
            await Clients.Group(room).SendAsync("ShowWho", $"Conectando {Context.ConnectionId}");
        }
    }
}
