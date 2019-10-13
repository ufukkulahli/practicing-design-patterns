namespace practicing_design_patterns.behavioral.@object.strategy.route
{
  public struct Coordinate
  {
    public string Latitude {get;}
    public string Longitude {get;}

    public Coordinate(string latitude, string longitude)
    {
      this.Latitude = latitude;
      this.Longitude = longitude;
    }

    public override string ToString() =>
      $"{this.Latitude}, {this.Longitude}";
  }
}
