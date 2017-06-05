using System.ComponentModel.DataAnnotations;

namespace SimpleChat.Web.ViewModels
{
    public class CreateMessageViewModel
    {
        [Required]
        public string Payload { get; set; }
    }
}
