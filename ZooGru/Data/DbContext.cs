using System.Data.Entity;

namespace ZooGru.Data
{
    public class DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbContext()
        {

        }
    }
}
