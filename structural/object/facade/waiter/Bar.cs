using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Bar : Kitchen
  {
    private readonly ICollection<string> drinksWeHaveAndCanPrepare = new List<string>();

    public Bar()
    {
      this.drinksWeHaveAndCanPrepare.Add("AWhiteWine");
      this.drinksWeHaveAndCanPrepare.Add("ARedWine");
      this.drinksWeHaveAndCanPrepare.Add("Whisky");
    }

    public IEnumerable<Order> Prepare(Reckoning reckoning) =>
          this.drinksWeHaveAndCanPrepare
              .Where(food => reckoning.Desires().Contains(food))
              .Select(food => new Order(food));
  }
}
