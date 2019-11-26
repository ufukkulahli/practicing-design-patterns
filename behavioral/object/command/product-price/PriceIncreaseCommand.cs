namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class PriceIncreaseCommand : Command
  {
    private Product product;
    private decimal price;

    public PriceIncreaseCommand(Product product, decimal price)
    {
      this.product = product;
      this.price = price;
    }

    public decimal Execute() => this.product.IncreasePrice(this.price);
    public void Undo() => this.product.DecreasePrice(this.price);
    public override string ToString() => this.product.ToString();
  }
}
