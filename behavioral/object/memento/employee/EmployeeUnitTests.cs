using Xunit;

namespace practicing_design_patterns.behavioral.@object.memento.employee
{
  public class EmployeeUnitTests
  {
    [Fact]
    public void SavesAndRestoresEmployeesPersonalInfo()
    {
      // Arrange
      var joe = new Employee{
        Name = "Joe Dalton",
        Phone = "5554443322"
      };

      var employeeHistory = new EmployeeHistory();
      employeeHistory.Save(joe);

      // (Update Joe's phone)
      joe.Phone = "1112223344";
      Assert.Equal("1112223344", joe.Phone);

      // Act
      employeeHistory.RevertChangesToPriorOf(joe);

      // Assert
      Assert.Equal("5554443322", joe.Phone);
    }
  }
}
