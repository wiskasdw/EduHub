using EduHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<User> Users { get; set; }
    }
}