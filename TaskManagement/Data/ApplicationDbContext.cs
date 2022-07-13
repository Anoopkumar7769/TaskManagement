using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TaskManagement.Models.ViewModels;

namespace TaskManagement.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RegisterViewModel> Register { get; set; }
        
        public DbSet<RecordsViewModel> Records { get; set; }

       
    }
}
