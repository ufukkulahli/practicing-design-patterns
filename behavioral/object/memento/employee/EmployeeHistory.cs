using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public sealed class EmployeeHistory
  {
    private readonly Stack<EmployeeMemento> employeeHistory =
      new Stack<EmployeeMemento>();

    public void Save(Employee employee) =>
      this.employeeHistory.Push(employee.Memento());

    public void RevertChangesToPriorOf(Employee employee) =>
      employee.RevertInfoChanges(this.employeeHistory.Pop());
  }
}
