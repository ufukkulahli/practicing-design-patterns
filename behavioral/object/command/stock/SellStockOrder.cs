namespace practicing_design_patterns.behavioral.@object.command.stock
{
  public sealed class SellStockOrder : Order
  {
    private readonly Stock stock;
    public SellStockOrder(Stock stock) => this.stock = stock;
    public bool Execute() => this.stock.Sell();
  }
}
