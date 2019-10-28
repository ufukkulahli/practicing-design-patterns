using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class ColdKitchen : Kitchen
  {
    private readonly ICollection<string> foodsWeCanPrepare = new List<string>();
    
    public ColdKitchen()
    {
      this.foodsWeCanPrepare.Add("AColdAppetizer");
      this.foodsWeCanPrepare.Add("AnOtherColdAppetizer");
    }

    public IEnumerable<Order> Prepare(Reckoning reckoning) =>
          this.foodsWeCanPrepare
              .Where(food => reckoning.Desires().Contains(food))
              .Select(food => new Order(food));
  }
}
