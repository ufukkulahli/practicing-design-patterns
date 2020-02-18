namespace practicing_design_patterns.creational.@object.singleton.database
{
  public sealed class Database
  {
    private readonly static Database instance = new Database();
    private Database() {}
    public static Database Instance() => instance;
  }
}