using Microsoft.AspNetCore.Mvc;

using SimpleChat.Web.ViewModels;
using SimpleChat.Data;

namespace SimpleChat.Web.Controllers
{
    [Produces("application/json")]
    //[Route("api/messages")]
    public class MessagesController : Controller
    {
        private IRepository _repository;

        public MessagesController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Send(string type, [FromBody] CreateMessageViewModel message)
        {
            switch (type)
            {
                case "send_text":
                    var textModel = new CreateTextMessageViewModel() { Payload = message.Payload };
                    this.ValidateViewModel(textModel);
                    return SendText(textModel);
                case "send_emoticon":
                    var emoticonModel = new CreateEmoticonMessageViewModel() { Payload = message.Payload };
                    this.ValidateViewModel(emoticonModel);
                    return SendEmoticon(emoticonModel);
                default:
                    return StatusCode(404);
            }
        }

        //[HttpGet]
        //[Route("get")]
        public IActionResult Get()
        {
            return StatusCode(200, _repository.GetAll());
        }

        //[HttpPost]
        //[Route("send-text")]
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

        //[HttpPost]
        //[Route("send-emoticon")]
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