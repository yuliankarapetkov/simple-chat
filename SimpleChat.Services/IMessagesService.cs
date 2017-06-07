using SimpleChat.Services.DTOs;

namespace SimpleChat.Services
{
    public interface IMessagesService
    {
        void SendMessage(CreateMessageDTO message);
    }
}
