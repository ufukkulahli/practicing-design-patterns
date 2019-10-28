using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public interface Kitchen
  {
    IEnumerable<Order> Prepare(Reckoning reckoning);
  }
}
