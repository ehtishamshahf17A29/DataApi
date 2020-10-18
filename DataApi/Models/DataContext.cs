using Microsoft.EntityFrameworkCore;

namespace DataApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Data> TodoItems { get; set; }
    }
}