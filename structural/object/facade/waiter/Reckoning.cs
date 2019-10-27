using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Reckoning
  {
    private readonly List<string> desiresOfCustomer;
    private Reckoning() => this.desiresOfCustomer = new List<string>();

    public Reckoning(params string[] desires)
    {
      this.desiresOfCustomer = new List<string>();
      this.desiresOfCustomer.AddRange(desires);
    }

    public static Reckoning Empty() => new Reckoning();
    public IReadOnlyCollection<string> Desires() => this.desiresOfCustomer.AsReadOnly();
  }
}
