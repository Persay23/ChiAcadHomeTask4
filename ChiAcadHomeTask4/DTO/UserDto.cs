using System.ComponentModel.DataAnnotations;

namespace ChiAcadHomeTask4.DTO
{
    public class UserDto
    {
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is incorrect")]
        public required string Email { get; set; }
    }
}