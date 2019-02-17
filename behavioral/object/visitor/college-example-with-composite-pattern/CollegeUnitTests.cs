using Xunit;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class CollegeUnitTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      CompositeEmployee principle =
        new CompositeEmployee
        (
          new Name("Cool principe"),
          new Department("department"),
          new YearsOfExperience(25)
        );

      CompositeEmployee headOfMathDepartment =
        new CompositeEmployee
        (
          new Name("John"),
          new Department("Math department"),
          new YearsOfExperience(17)
        );

      CompositeEmployee headOfCSDepartment =
        new CompositeEmployee
        (
          new Name("Jack"),
          new Department("CS department"),
          new YearsOfExperience(16)
        );

      Employee mathTeacherJim =
        new Employee
        (
          new Name("Jim"),
          new Department("Math department"),
          new YearsOfExperience(13)
        );

      Employee mathTeacherJoe =
        new Employee
        (
          new Name("Joe"),
          new Department("Math department"),
          new YearsOfExperience(8)
        );

      Employee csTeacherWilliam =
        new Employee
        (
          new Name("William"),
          new Department("CS department"),
          new YearsOfExperience(10)
        );

      Employee csTeacherSam =
        new Employee
        (
          new Name("Sam"),
          new Department("CS department"),
          new YearsOfExperience(9)
        );

      Employee csTeacherEric =
        new Employee
        (
          new Name("Eric"),
          new Department("CS department"),
          new YearsOfExperience(6)
        );

      headOfMathDepartment.Add(mathTeacherJim);
      headOfMathDepartment.Add(mathTeacherJoe);

      headOfCSDepartment.Add(csTeacherSam);
      headOfCSDepartment.Add(csTeacherEric);
      headOfCSDepartment.Add(csTeacherWilliam);

      principle.Add(headOfMathDepartment);
      principle.Add(headOfCSDepartment);

      IEmployeeVisitor employeeVisitor = new EmployeeVisitor();

      // Act
      principle.PrintStructures();
      principle.Accept(employeeVisitor);
      foreach (var employee in principle.Subordinates)
      {
        employee.Accept(employeeVisitor);
      }

      foreach (var employee in headOfMathDepartment.Subordinates)
      {
        employee.Accept(employeeVisitor);
      }

      foreach (var employee in headOfCSDepartment.Subordinates)
      {
        employee.Accept(employeeVisitor);
      }
    }
  }
}