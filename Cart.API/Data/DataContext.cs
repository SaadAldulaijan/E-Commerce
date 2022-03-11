using Cart.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cart.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<CartProduct> CartProduct { get; set; }

    }
}
