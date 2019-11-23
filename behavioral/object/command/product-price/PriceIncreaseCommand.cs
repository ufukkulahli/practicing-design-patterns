namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class PriceIncreaseCommand : Command
  {
    private Product phone;
    private decimal price;

    public PriceIncreaseCommand(Product phone, decimal price)
    {
      this.phone = phone;
      this.price = price;
    }

    public decimal Execute() => this.phone.IncreasePrice(this.price);
  }
}
