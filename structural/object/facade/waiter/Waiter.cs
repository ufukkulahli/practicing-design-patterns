using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Waiter
  {
    private Reckoning reckoning = Reckoning.Empty();
    private readonly IEnumerable<Kitchen> kitchens = new List<Kitchen>();
    public void ReceiveOrder(Reckoning reckoning) => this.reckoning = reckoning;
    public Orders Serve()
    {
      var orders = this.kitchens
                .Where(kitchen => kitchen.CanPrepare(this.reckoning))
                .Select(kitchen => kitchen.Prepare(this.reckoning));
      return new Orders();
    }
  }
}
