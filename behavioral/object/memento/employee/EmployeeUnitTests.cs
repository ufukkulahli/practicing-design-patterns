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

    [Fact]
    public void SavesAndRestoresMultipleEmployeesPersonalInfo()
    {
      // Arrange
      var joe = new Employee { Name = "Joe Dalton", Phone = "5554443322" };
      var jack = new Employee { Name = "Jack Dalton", Phone = "9998887766" };

      var employeeHistory = new EmployeeHistory();
      employeeHistory.Save(joe);
      employeeHistory.Save(jack);

      // (Update Joe's phone)
      joe.Phone = "1112223344";
      Assert.Equal("1112223344", joe.Phone);

      // (Update Jack's phone)
      jack.Phone = "0009998877";
      Assert.Equal("0009998877", jack.Phone);

      // Act
      employeeHistory.RevertChangesToPriorOf(joe);
      employeeHistory.RevertChangesToPriorOf(jack);

      // Assert
      Assert.Equal("5554443322", joe.Phone);
      Assert.Equal("9998887766", jack.Phone);
    }
  }
}
