namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public sealed class EmployeeMemento
  {
    private readonly string name;
    private readonly string phone;

    public EmployeeMemento(string name, string phone)
    {
      this.name = name;
      this.phone = phone;
    }
  }
}
