namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public sealed class Order
  {
    public readonly string Name;
    public Order(string name) => this.Name = name;
    public override string ToString() => this.Name;
  }
}
