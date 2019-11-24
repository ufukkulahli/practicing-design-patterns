namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class PriceDecreaseCommand : Command
  {
    private Product product;
    private decimal price;

    public PriceDecreaseCommand(Product product, decimal price)
    {
      this.product = product;
      this.price = price;
    }

    public decimal Execute() => this.product.DecreasePrice(this.price);
  }
}
