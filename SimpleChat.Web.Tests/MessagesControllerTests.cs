using Microsoft.AspNetCore.Mvc;
using SimpleChat.Data;
using SimpleChat.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xunit;

namespace SimpleChat.Web.Tests
{
    public class MessagesControllerTests
    {
        private List<Message> GetTestMessages()
        {
            var messages = new List<Message>();
            messages.Add(new Message()
            {
                Id = 1,
                Type = MessageType.Text,
                CreatedAt = DateTime.Now,
                Payload = "Sample text"
            });
            messages.Add(new Message()
            {
                Id = 1,
                Type = MessageType.Emoticon,
                CreatedAt = DateTime.Now,
                Payload = "Smpl emo"
            });
            return messages;
        }

        //[Fact]
        //public void GetAll_ReturnsOkay_WithAListOfMessages()
        //{
        //    var repository = new MockDbMessagesRepository(GetTestMessages());
        //    var controller = new MessagesController(repository);

        //    var result = controller.Get();

        //    var objectResult = result as ObjectResult;
        //    Assert.NotNull(objectResult);

        //    var model = objectResult.Value as List<Message>;
        //    Assert.NotNull(model);

        //    Assert.NotSame(GetTestMessages(), model);
        //}

        //[Fact]
        //public void SendText_ReturnsPreconditionFailedIfInvalid()
        //{
        //    var repository = new MockDbMessagesRepository(GetTestMessages());
        //    var controller = new MessagesController(repository);

        //    var model = new CreateTextMessageViewModel()
        //    {
        //        Payload = new string('.', 161)
        //    };

        //    Helpers.ValidateViewModel(controller, model);
        //    var result = controller.SendText(model);

        //    var statusCodeResult = result as StatusCodeResult;
        //    Assert.NotNull(statusCodeResult);

        //    Assert.Equal(412, statusCodeResult.StatusCode);
        //}

        //[Fact]
        //public void SendEmoticon_ReturnsPreconditionFailedIfInvalid()
        //{
        //    var repository = new MockDbMessagesRepository(GetTestMessages());
        //    var controller = new MessagesController(repository);

        //    var model = new CreateEmoticonMessageViewModel()
        //    {
        //        Payload = new string('.', 11)
        //    };

        //    Helpers.ValidateViewModel(controller, model);
        //    var result = controller.SendEmoticon(model);

        //    var statusCodeResult = result as StatusCodeResult;
        //    Assert.NotNull(statusCodeResult);

        //    Assert.Equal(412, statusCodeResult.StatusCode);
        //}
    }
}
