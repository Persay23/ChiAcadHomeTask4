using ChiAcadHomeTask4.DTO;

namespace ChiAcadHomeTask4.Models
{
    public class HomeViewModel
    {
        public UserDto NewUser { get; set; } = new UserDto
        {
            Name = string.Empty,
            Email = string.Empty
        };
        public List<User> Users { get; set; } = [];
    }
}