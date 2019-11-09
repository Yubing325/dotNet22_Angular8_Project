using System.ComponentModel.DataAnnotations;

namespace App.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4, ErrorMessage = "Password length must be in range of 4 to 8")]
        public string Password { get; set; }
    }
}