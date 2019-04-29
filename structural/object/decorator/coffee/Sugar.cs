namespace practicing_design_patterns.structural.@object.decorator.coffee
{
  class Sugar : IDecorator
  {
    readonly ICoffee coffee;
    internal Sugar(ICoffee coffee)=>this.coffee=coffee;
    public int Cost()=>this.coffee.Cost() + 1;
    public string Description()=>this.coffee.Description() + ", with sugar";
  }
}