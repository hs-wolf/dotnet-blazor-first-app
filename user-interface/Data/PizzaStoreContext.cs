using Microsoft.EntityFrameworkCore;
using user_interface.Models;

namespace user_interface.Data;

public class PizzaStoreContext : DbContext
{
  public PizzaStoreContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<PizzaSpecial> Specials { get; set; }
}