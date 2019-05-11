namespace practicing_design_patterns.structural.@object.composite.order
{
  public sealed class Product : IProduct
  {
    private readonly decimal price;
    private readonly string name;
    public Product(decimal price, string name)
    {
      this.price = price;
      this.name = name;
    }
    public decimal Price() => this.price;
    public string Name() => this.name;
  }
}
