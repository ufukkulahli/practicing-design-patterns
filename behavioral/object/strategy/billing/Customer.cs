using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public sealed class Customer
  {
    private readonly ICollection<Beverage> beverages = new List<Beverage>();
    public void Consume(Beverage beer) => this.beverages.Add(beer);
    public decimal Pay() => this.beverages.Sum(b => b.Price());
  }
}
