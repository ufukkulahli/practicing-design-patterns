namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  public class Balance
  {
    private decimal value;

    public Balance(decimal value)
    {
      this.value = value;
    }

    public static Balance Zero => new Balance(new decimal(0));

    protected internal void Increase(Amount amount)
    {
      this.value += amount.value;
    }

    public decimal Get()
    {
      return this.value;
    }
  }
}