using ChiAcadHomeTask4.Data;
using ChiAcadHomeTask4.DTO;
using ChiAcadHomeTask4.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChiAcadHomeTask4.Controllers;
public class HomeController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;

    [HttpGet]
    public IActionResult Index()
    {
        return View(new UserDto
        {
            Name = string.Empty,
            Email = string.Empty
        });
    }

    [HttpPost]
    public IActionResult BecomeDeveloper(UserDto dto)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", dto);
        }

        var user = new User
        {
            Name = dto.Name,
            Email = dto.Email
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        var allUsers = _context.Users.ToList();

        var model = new DeveloperViewModel
        {
            CurrentUser = user,
            AllUsers = allUsers
        };

        return View("Developer", model);
    }
}