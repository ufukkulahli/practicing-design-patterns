namespace practicing_design_patterns.structural.@object.decorator.carservice
{
  internal class BasicInspection : ICarService
  {
    public decimal GetCost() => 25;
    public string GetDescription() => "Basic inspection";
  }
}
