using BlazingPizzaDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaDemo.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<PizzaSpecial> Specials { get; set; }
}
