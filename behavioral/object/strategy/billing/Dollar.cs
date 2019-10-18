namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public struct Dollar : Currency
  {
    public decimal Value { get; }
    public Dollar(decimal value) => this.Value = value;
  }
}
