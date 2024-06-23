using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;

namespace InventoryManagement.Data;
/// <summary>
/// Providing the context to the classes in Models
/// </summary>

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options)
  : base(options)
  {
  }

  // Creating DbSet to each class in the Models
  public DbSet<Employee> Employees { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<Report> Reports { get; set; }
  public DbSet<Store> Stores { get; set; }
}