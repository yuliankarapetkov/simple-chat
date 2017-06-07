using SimpleChat.Services.DTOs;

namespace SimpleChat.Web.Infrastructure
{
    public interface IMessageTypeResolver
    {
        CreateMessageDTO ResolveMessageType(string type, CreateMessageDTO message);
    }
}
