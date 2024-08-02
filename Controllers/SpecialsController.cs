using BlazingPizzaDemo.Data;
using BlazingPizzaDemo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaDemo.Controllers;

[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _context;

    public SpecialsController(PizzaStoreContext context)
    {
        _context = context;
    }

    [HttpGet("specials")]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _context.Specials.ToListAsync()).OrderByDescending(x => x.BasePrice).ToList();
    }
}
