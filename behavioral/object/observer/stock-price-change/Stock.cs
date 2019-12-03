using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.observer.stock_price_change
{
  public sealed class Stock
  {
    private readonly ICollection<Investor> Investors = new List<Investor>();
    private string name;
    private decimal price;

    public Stock(string name, decimal price)
    {
      this.name = name;
      this.price = price;
    }

    public void UpdatePrice(decimal price)
    {
      if(this.price == price)
      {
        return;
      }
      this.price = price;
      this.NotifyInvestors();
    }

    private void NotifyInvestors()
    {
      foreach(var investor in this.Investors)
      {
        investor.Notify(this.ToString());
      }
    }

    public void AddInvestor(Investor investor) => this.Investors.Add(investor);
    public override string ToString() => $"{this.name} stock price just changed to {this.price}";
  }
}
