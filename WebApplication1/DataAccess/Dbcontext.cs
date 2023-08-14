using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<Student> Students { get; set; }
    }
}
