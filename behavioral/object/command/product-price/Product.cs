namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class Product
  {
    private string brand;
    private decimal price;

    public Product(string brand, decimal price)
    {
      this.brand = brand;
      this.price = price;
    }

    public decimal IncreasePrice(decimal price)
    {
      this.price = this.price + price;
      return this.price;
    }

    public decimal DecreasePrice(decimal price)
    {
      this.price = this.price - price;
      return this.price;
    }
 
    public decimal Price()
    {
      ProductPriceUnitTests.TestOutputHelper.WriteLine(this.ToString());
      return this.price;
    }
    public override string ToString() => $"{this.brand}'s price is {this.price.ToString()}";
  }
}
