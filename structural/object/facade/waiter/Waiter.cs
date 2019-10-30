using System.Linq;
using System.Collections.Generic;
using System;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Waiter
  {
    private Reckoning reckoning = Reckoning.Empty();
    private readonly ICollection<Kitchen> kitchens = new List<Kitchen>();
    public Waiter() => this.LearnKitchens();

    private void LearnKitchens()
    {
      this.kitchens.Add(new ColdKitchen());
      this.kitchens.Add(new HotKitchen());
      this.kitchens.Add(new Bar());
    }

    public void ReceiveOrder(Reckoning reckoning) => this.reckoning = reckoning;
    public Orders Serve() =>
        new Orders(this.kitchens
          .SelectMany(kitchen => kitchen.Prepare(this.reckoning)));
  }
}
