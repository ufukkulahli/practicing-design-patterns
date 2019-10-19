namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public sealed class Drink : Beverage
  {
    private Money money;
    private Billing billing;

    public Drink(Money money, Billing billing)
    {
      this.money = money;
      this.billing = billing;
    }

    public decimal Price() => this.billing.Apply(this.money.Value());
  }
}
