using BlazorChat.Server.Data;
using BlazorChat.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Server.Controllers
{
    public class ChatController : ControllerBase
    {
        private readonly ChatDataContext _context;

        public ChatController(ChatDataContext context)
        {
            _context = context;
        }

        [HttpGet("chats")]
        public async Task<ActionResult> GetAllChats()
        {
            var response = await _context.Chats
                .Select(c => new ChatModel
                {
                    From = c.From,
                    Message = c.Message,
                    When = c.When
                }).ToListAsync();

            return Ok(response);
        }
    }
}
