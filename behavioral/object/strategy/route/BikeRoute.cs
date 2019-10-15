namespace practicing_design_patterns.behavioral.@object.strategy.route
{
  public sealed class BikeRoute : Route
  {
    public string Start(Coordinate a, Coordinate b) =>
      $"Bike route for: {a}-{b}";
  }
}
