using SimpleChat.Data;
using SimpleChat.Services.DTOs;

namespace SimpleChat.Services
{
    public class MessagesService : IMessagesService
    {
        private IRepository _repository;

        public MessagesService(IRepository repository)
        {
            _repository = repository;
        }

        public void SendMessage(CreateMessageDTO message)
        {
            var messageEntity = message.ToEntity();

            _repository.Add(messageEntity);
            _repository.SaveChanges();
        }
    }
}
