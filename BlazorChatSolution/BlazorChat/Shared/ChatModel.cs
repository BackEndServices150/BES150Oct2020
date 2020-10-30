using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChat.Shared
{
    public class ChatModel
    {
        public string Message { get; set; }
        public string From { get; set; }
        public DateTime When { get; set; }
    }
}
