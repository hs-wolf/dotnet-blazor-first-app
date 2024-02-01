using Microsoft.EntityFrameworkCore;

namespace improve_navigation;

public class PizzaStoreContext : DbContext
{
  public PizzaStoreContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<PizzaSpecial> Specials { get; set; }
}
