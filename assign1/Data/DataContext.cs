using Microsoft.EntityFrameworkCore;
using assign1.Models;

namespace assign1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options)
        {
        }

        public DbSet<information_customer> information_customer { get; set; }
    }
}
