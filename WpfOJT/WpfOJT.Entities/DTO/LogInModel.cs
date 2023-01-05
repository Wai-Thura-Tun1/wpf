using System.ComponentModel.DataAnnotations;

namespace WpfOJT.Entities.DTO
{
    public class LogInViewModel
    {
        [Required]
        public string Email { get; set; } = "";

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
    }
}
