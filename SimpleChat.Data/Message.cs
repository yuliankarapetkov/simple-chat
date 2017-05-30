using System;

namespace SimpleChat.Data
{
    public class Message
    {
        public long Id { get; set; }
        public MessageType Type { get; set; }
        public string Payload { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
