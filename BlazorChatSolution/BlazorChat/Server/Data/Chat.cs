using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Server.Data
{
    public class Chat
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string From { get; set; }
        public DateTime When { get; set; }
    }
}
