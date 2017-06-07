using Microsoft.AspNetCore.Mvc;
using SimpleChat.Web.Infrastructure;
using SimpleChat.Services.DTOs;
using SimpleChat.Services;

namespace SimpleChat.Web.Controllers
{
    [Produces("application/json")]
    public class MessagesController : Controller
    {
        private IMessagesService _messagesService;
        private IMessageTypeResolver _messageTypeResolver;

        public MessagesController(IMessagesService messagesService, IMessageTypeResolver messageTypeResolver)
        {
            _messagesService = messagesService;
            _messageTypeResolver = messageTypeResolver;
        }

        [HttpPost]
        public IActionResult Send(string type, [FromBody] CreateMessageDTO message)
        {
            var transformedMessage = _messageTypeResolver.ResolveMessageType(type, message);
            this.ValidateViewModel(transformedMessage);

            if (!ModelState.IsValid)
            {
                return StatusCode(412);
            }

            _messagesService.SendMessage(transformedMessage);

            return StatusCode(201);
        }
    }
}