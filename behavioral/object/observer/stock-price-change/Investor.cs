namespace practicing_design_patterns.behavioral.@object.observer.stock_price_change
{
  public sealed class Investor
  {
    private string name;
    public string LastStockChangeInfo {get; private set;} = "Not last stock info";
    public Investor(string name) => this.name = name;
    public void Notify(string changeInfo) => this.LastStockChangeInfo = changeInfo;
  }
}
