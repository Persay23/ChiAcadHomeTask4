namespace ChiAcadHomeTask4.Models
{
    public class DeveloperViewModel
    {
        public User CurrentUser { get; set; } = null!;
        public List<User> AllUsers { get; set; } = [];
    }
}