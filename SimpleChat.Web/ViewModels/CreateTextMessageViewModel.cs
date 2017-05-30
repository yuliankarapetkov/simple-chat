using System;
using System.ComponentModel.DataAnnotations;

using SimpleChat.Data;

namespace SimpleChat.Web.ViewModels
{
    public class CreateTextMessageViewModel
    {
        [Required]
        [StringLength(160, MinimumLength = 1)]
        public string Payload { get; set; }

        public Message ToEntity()
        {
            var messageEntity = new Message();

            messageEntity.Payload = this.Payload;
            messageEntity.Type = MessageType.Text;
            messageEntity.CreatedAt = DateTime.UtcNow;

            return messageEntity;
        }
    }
}
