namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public sealed class EmployeeMemento
  {
    public readonly string Name;
    public readonly string Phone;

    public EmployeeMemento(string name, string phone)
    {
      this.Name = name;
      this.Phone = phone;
    }
  }
}
