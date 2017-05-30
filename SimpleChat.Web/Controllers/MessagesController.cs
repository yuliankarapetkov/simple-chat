using Microsoft.AspNetCore.Mvc;

using SimpleChat.Web.ViewModels;
using SimpleChat.Data;

namespace SimpleChat.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/messages")]
    public class MessagesController : Controller
    {
        private IRepository _repository;

        public MessagesController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            return StatusCode(200, _repository.GetAll());
        }

        [HttpPost]
        [Route("send-text")]
        public IActionResult SendText([FromBody]CreateTextMessageViewModel message)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(412);
            }

            var messageEntity = message.ToEntity();

            _repository.Add(messageEntity);
            _repository.SaveChanges();

            return StatusCode(201);
        }

        [HttpPost]
        [Route("send-emoticon")]
        public IActionResult SendEmoticon([FromBody]CreateEmoticonMessageViewModel message)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(412);
            }

            var messageEntity = message.ToEntity();

            _repository.Add(messageEntity);
            _repository.SaveChanges();

            return StatusCode(201);
        }
    }
}