using BlazorChat.Server.Data;
using BlazorChat.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Server.Hubs
{
    public class ChatHub : Hub
    {

        private readonly ChatDataContext _context;

        public ChatHub(ChatDataContext context)
        {
            _context = context;
        }

        public async Task AddChat(ChatModel chat)
        {
            var chatToSave = new Chat { From = chat.From, Message = chat.Message, When = chat.When };
            _context.Chats.Add(chatToSave);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ChatReceived", chat);
        }
    }
}
