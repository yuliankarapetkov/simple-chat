using System.ComponentModel.DataAnnotations;

using SimpleChat.Data;

namespace SimpleChat.Services.DTOs
{
    public class CreateTextMessageDTO : CreateMessageDTO
    {
        [StringLength(160, MinimumLength = 1)]
        public override string Payload { get; set; }

        public override Message ToEntity()
        {
            var messageEntity = base.ToEntity();
            messageEntity.Type = MessageType.Text;

            return messageEntity;
        }
    }
}
