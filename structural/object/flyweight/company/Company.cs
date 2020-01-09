namespace practicing_design_patterns.structural.@object.flyweight.company
{
  public sealed class Company : ICompany
  {
    private string name = string.Empty;
    private string location = string.Empty;
    private string agreement = string.Empty;

    public Company(string name, string location)
    {
      this.name = name;
      this.location = location;
    }

    public string Name { get=>this.name; }
    public string Agreement { get=> CompanyFlyweight.Agreement; }
  }
}
