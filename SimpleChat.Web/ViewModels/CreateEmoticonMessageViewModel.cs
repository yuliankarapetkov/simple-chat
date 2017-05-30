using System;
using System.ComponentModel.DataAnnotations;

using SimpleChat.Data;

namespace SimpleChat.Web.ViewModels
{
    public class CreateEmoticonMessageViewModel
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        [RegularExpression("^\D*$")]
        public string Payload { get; set; }

        public Message ToEntity()
        {
            var messageEntity = new Message();

            messageEntity.Payload = this.Payload;
            messageEntity.Type = MessageType.Emoticon;
            messageEntity.CreatedAt = DateTime.UtcNow;

            return messageEntity;
        }
    }
}
