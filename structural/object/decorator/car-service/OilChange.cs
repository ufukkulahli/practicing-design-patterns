namespace practicing_design_patterns.structural.@object.decorator.carservice
{
  internal class OilChange : ICarService
  {
    private readonly ICarService carService;
    internal OilChange(ICarService carService) => this.carService = carService;
    public decimal GetCost() => this.carService.GetCost() + 5;
    public string GetDescription() =>
      this.carService.GetDescription() + ", Oil change";
  }
}
