
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.DataAcessLayer
{

    public interface IContext
    {
        DbSet<Product> Products { get; }
        DbSet<Restaurant> Restaurants { get; }
        DbSet<Table> Tables { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
    public class Context : DbContext, IContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Restaurant> Restaurants { get; set; } = null!;
        public DbSet<Table> Tables { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Filename=Database");
    }
}