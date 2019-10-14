namespace practicing_design_patterns.behavioral.@object.strategy.route
{
  public sealed class RoadRoute : Route
  {
    public string Start(Coordinate a, Coordinate b) =>
      $"Road route for: {a}-{b}";
  }
}
