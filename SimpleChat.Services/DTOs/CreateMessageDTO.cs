using System;
using System.ComponentModel.DataAnnotations;

using SimpleChat.Data;

namespace SimpleChat.Services.DTOs
{
    public class CreateMessageDTO
    {
        [Required]
        public virtual string Payload { get; set; }

        public virtual Message ToEntity()
        {
            var messageEntity = new Message();

            messageEntity.Payload = this.Payload;
            messageEntity.CreatedAt = DateTime.UtcNow;

            return messageEntity;
        }
    }
}
