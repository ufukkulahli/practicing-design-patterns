namespace practicing_design_patterns.behavioral.@object.command.stock
{
  public sealed class BuyStockOrder : Order
  {
    private readonly Stock stock;
    public BuyStockOrder(Stock stock) => this.stock = stock;
    public bool Execute() => this.stock.Buy();
  }
}
