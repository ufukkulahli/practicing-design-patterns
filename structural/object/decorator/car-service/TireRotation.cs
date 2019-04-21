namespace practicing_design_patterns.structural.@object.decorator.carservice
{
  internal class TireRotation : ICarService
  {
    private readonly ICarService carService;
    internal TireRotation(ICarService carService) => this.carService = carService;
    public decimal GetCost() => this.carService.GetCost() + 9;
    public string GetDescription() =>
      this.carService.GetDescription() + ", Tire rotation";
  }
}
