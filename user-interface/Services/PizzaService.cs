using user_interface.Models;

namespace user_interface.Services;

public class PizzaService
{
  public Task<Pizza[]> GetPizzasAsync()
  {
    Pizza[] placeholderPizzas = [
        new() { Id = 1, OrderId = 1 },
        new() { Id = 2, OrderId = 1 },
    ];
    return Task.FromResult(placeholderPizzas);
  }
}