namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  public class Currency
  {
    private readonly string value;

    public Currency(string value)
    {
      this.value = value;
    }

    public override string ToString()
    {
      return this.value;
    }
  }
}