namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public struct Money
  {
    private Currency currency;
    public Money(Currency currency) => this.currency = currency;
    public decimal Value() => this.currency.Value;
  }
}
