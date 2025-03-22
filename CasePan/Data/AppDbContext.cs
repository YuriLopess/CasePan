﻿using CasePan.Models;
using Microsoft.EntityFrameworkCore;

namespace CasePan.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
 
        }

        public DbSet<User> Users { get; set; }
    }
}
