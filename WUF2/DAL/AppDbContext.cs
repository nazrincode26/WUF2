using Microsoft.EntityFrameworkCore;

namespace WUF2.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }   
}
