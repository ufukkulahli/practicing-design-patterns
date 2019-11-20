namespace practicing_design_patterns.behavioral.@object.command.stock
{
  public sealed class Agent
  {
    public bool PlaceOrder(Order buyStockOrder) => buyStockOrder.Execute();
  }
}
