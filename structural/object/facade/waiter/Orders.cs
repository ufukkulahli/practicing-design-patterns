using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Orders
  {
    private IEnumerable<Order> values;
    public Orders(IEnumerable<Order> orders) => this.values = orders;
    public IReadOnlyCollection<Order> Values() => this.values.ToList().AsReadOnly();
    public override string ToString() => string.Join(',', this.values);
  }
}
