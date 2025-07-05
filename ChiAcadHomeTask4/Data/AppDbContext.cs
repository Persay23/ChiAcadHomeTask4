using ChiAcadHomeTask4.Models;
using Microsoft.EntityFrameworkCore;
namespace ChiAcadHomeTask4.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}