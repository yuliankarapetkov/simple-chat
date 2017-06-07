using System.ComponentModel.DataAnnotations;

using SimpleChat.Data;

namespace SimpleChat.Services.DTOs
{
    public class CreateEmoticonMessageDTO : CreateMessageDTO
    {
        [StringLength(10, MinimumLength = 2)]
        [RegularExpression(@"^\D*$")]
        public override string Payload { get; set; }

        public override Message ToEntity()
        {
            var messageEntity = base.ToEntity();
            messageEntity.Type = MessageType.Emoticon;

            return messageEntity;
        }
    }
}
