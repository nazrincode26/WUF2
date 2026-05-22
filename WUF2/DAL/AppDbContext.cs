using Microsoft.EntityFrameworkCore;
using WUF2.Models;

namespace WUF2.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        
    }   
}
