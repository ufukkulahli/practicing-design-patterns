namespace practicing_design_patterns.structural.@object.composite.order
{
  public sealed class Product : IProduct
  {
    private readonly decimal price;
    public Product(decimal price) => this.price = price;
    public decimal Price() => this.price;
  }
}
