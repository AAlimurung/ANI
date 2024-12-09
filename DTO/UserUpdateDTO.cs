using System.ComponentModel.DataAnnotations;

namespace ANI.DTO;

public class UserUpdateDTO
{

    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = null!;
    [Required]
    [MaxLength(50)]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    [MaxLength(50)]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string? NewPassword { get; set; } = null!;    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = null!;
    [Required]
    [MaxLength(11), MinLength(11)]
    public string PhoneNumber { get; set; } = null!;
    [Required]
    public string Address { get; set; } = null!;
    [Required]
    public bool IsFarmer { get; set; }
    public IFormFile? ProfilePictureUrl { get; set; }
}