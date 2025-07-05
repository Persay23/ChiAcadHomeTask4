using Microsoft.AspNetCore.Mvc;
using ChiAcadHomeTask4.Models;
using ChiAcadHomeTask4.DTO;
using ChiAcadHomeTask4.Data;

namespace ChiAcadHomeTask4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public ActionResult<User> CreateUser([FromBody] UserDto newUserDto)
        {
            var newUser = new User
            {
                Name = newUserDto.Name,
                Email = newUserDto.Email
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserDto updatedUserDto)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            user.Name = updatedUserDto.Name;
            user.Email = updatedUserDto.Email;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }   
    }
}