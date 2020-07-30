using Heartcooking.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Product> Products {get; set;}
        public DbSet<User> Users {get; set;}
    }
}