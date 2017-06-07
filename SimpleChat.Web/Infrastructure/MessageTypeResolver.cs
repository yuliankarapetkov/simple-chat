using SimpleChat.Services.DTOs;

namespace SimpleChat.Web.Infrastructure
{
    public class MessageTypeResolver : IMessageTypeResolver
    {
        public CreateMessageDTO ResolveMessageType(string type, CreateMessageDTO message)
        {
            var messageDto = new CreateMessageDTO();

            switch (type)
            {
                case "send_text":
                    messageDto = new CreateTextMessageDTO() { Payload = message.Payload };
                    break;
                case "send_emoticon":
                    messageDto = new CreateEmoticonMessageDTO() { Payload = message.Payload };
                    break;
                default:
                    throw new System.Exception("Wrong type parameter");
            }

            return messageDto;
        }
    }
}
