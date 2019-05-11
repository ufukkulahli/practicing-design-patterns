using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.order
{
  public sealed class Box : IProduct
  {
    private readonly decimal price;
    private readonly ICollection<IProduct> products = new List<IProduct>();
    public Box(decimal price) => this.price = price;
    public void AddProduct(IProduct product) => this.products.Add(product);
    public void RemoveProduct(IProduct product) => this.products.Remove(product);
    public decimal Price()
    {
      decimal totalPrice = 0;
      foreach(var p in this.products)
      {
        totalPrice += p.Price();
      }
      return totalPrice;
    }
  }
}
