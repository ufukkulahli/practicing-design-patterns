using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.order
{
  public sealed class Box : IProduct
  {
    private readonly decimal price;
    private readonly string name;
    private readonly ICollection<IProduct> products = new List<IProduct>();
    public Box() : this(0, "") {}
    public Box(string name) : this(0, name) {}
    public Box(decimal price) : this(price, "") {}
    public Box(decimal price, string name)
    {
      this.price = price;
      this.name = name;
    }
    public void AddProduct(IProduct product) => this.products.Add(product);
    public void RemoveProduct(IProduct product) => this.products.Remove(product);
    public decimal Price()
    {
      decimal totalPrice = this.price;
      foreach(var p in this.products)
      {
        totalPrice += p.Price();
      }
      return totalPrice;
    }
  }
}
