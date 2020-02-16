namespace practicing_design_patterns.creational.@object.singleton.connection_string
{
  public sealed class ConnectionString
  {
    private static readonly ConnectionString instance = new ConnectionString();

    private ConnectionString(){}

    public static ConnectionString Instance() => instance;

    public string Value() => "database=localhost;user=admin;pass=admin";
  }
}