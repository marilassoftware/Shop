using System.ComponentModel.DataAnnotations;

namespace Shop.Common.Models
{
    public class RecoverPasswordRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
