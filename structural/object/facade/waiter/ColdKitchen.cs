using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class ColdKitchen : Kitchen
  {
    private readonly List<string> thingsWeCanPrepare;
    
    public ColdKitchen()
    {
      this.thingsWeCanPrepare.Add("AColdAppetizer");
      this.thingsWeCanPrepare.Add("AnOtherColdAppetizer");
    }

    public bool CanPrepare(Reckoning reckoning) =>
      this.thingsWeCanPrepare.Any(thing => reckoning.Desires().Contains(thing));

    public Orders Prepare(Reckoning reckoning)
    {
      throw new System.NotImplementedException();
    }
  }
}
