namespace practicing_design_patterns.structural.@object.decorator.coffee
{
  class Milk : IDecorator
  {
    readonly ICoffee coffee;
    internal Milk(ICoffee coffee)=>this.coffee=coffee;
    public int Cost()=>this.coffee.Cost() + 5;
    public string Description()=>this.coffee.Description() + ", with milk";
  }
}