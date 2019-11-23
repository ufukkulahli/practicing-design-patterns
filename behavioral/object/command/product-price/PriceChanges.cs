namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class PriceChanges
  {
    private Command priceChangeCommand;
    public decimal Apply(Command priceChangeCommand)
    {
      this.priceChangeCommand = priceChangeCommand;
      return this.priceChangeCommand.Execute();
    }
  }
}
