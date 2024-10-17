
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

// Pass the options, providing SQL server connection string
public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
