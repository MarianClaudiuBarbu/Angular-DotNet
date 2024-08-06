using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models;

public class RegisterDTO
{
    [Required]
    [MaxLength(200)]
    public required string Username { get; set; }

    [Required]
    [MinLength(8)]
    public required string Password { get; set; }
}
