using Microsoft.EntityFrameworkCore;

namespace ZooGru.Data
{
    public class ZooGruDbContext : DbContext
    {
        //public DbSet<Animal> Animals { get; set; }
        public ZooGruDbContext(DbContextOptions options) : base(options)
        {

        }

       
    }
}
