using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class HotKitchen : Kitchen
  {
    private readonly ICollection<string> foodsWeCanPrepare = new List<string>();
    
    public HotKitchen()
    {
      this.foodsWeCanPrepare.Add("AHotEntree");
      this.foodsWeCanPrepare.Add("AnOtherHotEntree");
    }

    public IEnumerable<Order> Prepare(Reckoning reckoning) =>
          this.foodsWeCanPrepare
              .Where(food => reckoning.Desires().Contains(food))
              .Select(food => new Order(food));
  }
}
