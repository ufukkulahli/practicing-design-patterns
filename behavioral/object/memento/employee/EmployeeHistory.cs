using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public sealed class EmployeeHistory
  {
    private readonly Stack<EmployeeMemento> employeeHistory =
      new Stack<EmployeeMemento>();

    public void Save(Employee joe) =>
      this.employeeHistory.Push(joe.Memento());

    public void RevertChangesToPrior(Employee employee) =>
      employee.RevertInfoChanges(this.employeeHistory.Pop());
  }
}
