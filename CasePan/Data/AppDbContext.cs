using CasePan.Models;
using Microsoft.EntityFrameworkCore;

namespace CasePan.Data
{
    // DbContext class for interacting with the database, specifically for UserModel
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet representing the Users table in the database
        public DbSet<UserModel> Users { get; set; }
    }
}