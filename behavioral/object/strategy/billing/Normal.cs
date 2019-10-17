namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public sealed class Normal : Billing
  {
    public decimal Apply(decimal price) => price;
  }
}
