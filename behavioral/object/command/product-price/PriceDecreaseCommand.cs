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
    public void Undo() => this.product.IncreasePrice(this.price);
    public override string ToString() => this.product.ToString();
  }
}
