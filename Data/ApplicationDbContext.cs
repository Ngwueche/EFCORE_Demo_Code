using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE_Demo_Code.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_Demo_Code.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WISEMAN\\SQLEXPRESS;Database=EFCoreDemoCode;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
