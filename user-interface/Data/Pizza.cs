namespace user_interface.Data;

public class Pizza
{
  public int PizzaId { get; set; }

  public string Name { get; set; } = "";

  public string Description { get; set; } = "";

  public decimal Price { get; set; }

  public bool Vegetarian { get; set; }

  public bool Vegan { get; set; }
}

public class PizzaService
{
  public Task<Pizza[]> GetPizzasAsync()
  {
    Pizza[] placeholderPizzas = {
        new() { PizzaId = 1, Name = "Margherita", Description = "Classic margherita", Price = 9.99m, Vegetarian = true, Vegan = false },
        new() { PizzaId = 2, Name = "Pepperoni", Description = "Pepperoni with extra cheese", Price = 12.99m, Vegetarian = false, Vegan = false },
    };
    return Task.FromResult(placeholderPizzas);
  }
}