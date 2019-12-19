namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public sealed class Employee
  {
    public string Name { get; set; }
    public string Phone { get; set; }
    public EmployeeMemento Memento() => new EmployeeMemento(this.Name, this.Phone);

    public void RevertInfoChanges(EmployeeMemento employeeMemento)
    {
      this.Name = employeeMemento.Name;
      this.Phone = employeeMemento.Phone;
    }
  }
}
