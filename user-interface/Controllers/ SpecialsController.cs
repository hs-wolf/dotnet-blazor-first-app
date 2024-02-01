using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using user_interface.Data;
using user_interface.Models;

namespace user_interface.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
  private readonly PizzaStoreContext _db;

  public SpecialsController(PizzaStoreContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
  {
    return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
  }
}