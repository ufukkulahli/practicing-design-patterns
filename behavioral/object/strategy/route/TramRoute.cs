namespace practicing_design_patterns.behavioral.@object.strategy.route
{
  public sealed class TramRoute : Route
  {
    public string Start(Coordinate a, Coordinate b) =>
      $"Tram route for: {a}-{b}";
  }
}
