using cryptostatistics.Entities;
using Microsoft.EntityFrameworkCore;

namespace cryptostatistics.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<Crypto> cryptos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
