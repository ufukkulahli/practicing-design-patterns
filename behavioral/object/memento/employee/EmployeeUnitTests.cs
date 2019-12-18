namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public class EmployeeUnitTests
  {
    public void SavesAndRestoresEmployeesPersonalInfo()
    {
      // Arrange
      var joe = new Employee{
        Name = "Joe Dalton",
        Phone = "5554443322"
      };

      var employeeHistory = new EmployeeHistory();
      employeeHistory.Save(joe);

      // Act

      // Assert

    }
  }
}
