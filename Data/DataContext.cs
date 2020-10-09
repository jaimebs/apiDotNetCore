using apiDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace apiDotNetCore.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}