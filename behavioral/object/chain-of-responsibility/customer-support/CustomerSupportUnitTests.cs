using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.customersupport
{
  public class CustomerSupportUnitTests
  {
    public static ITestOutputHelper TestOutputHelper;

    public CustomerSupportUnitTests(ITestOutputHelper helper)
    {
      TestOutputHelper = helper;
    }

    [Fact]
    public void CustomerSupportsShouldHandleTheProblemByTheirResponsibilities()
    {
      // Arrange
      // Customer support team
      var frontDesk = new FrontDesk();
      var lead = new Lead();
      var engineer = new Engineer();
      var manager = new Manager();

      // Build Chain - Hierarchy in order frontDesk->lead->engineer->manager
      frontDesk.SetEscalation(lead);
      lead.SetEscalation(engineer);
      engineer.SetEscalation(manager);

      // Let's create some problem
      var simpleProblem = new Problem(ProblemSeverity.Simple);
      var criticalProblem = new Problem(ProblemSeverity.Critical);

      // Act
      frontDesk.SolveProblem(simpleProblem);
      frontDesk.SolveProblem(criticalProblem);

      // Assert
      Assert.True(simpleProblem.IsSolved);
      Assert.Equal(frontDesk, simpleProblem.solvedBy);
      Assert.True(criticalProblem.IsSolved);
      Assert.NotEqual(frontDesk, criticalProblem.solvedBy);
      Assert.NotEqual(lead, criticalProblem.solvedBy);
      Assert.Equal(engineer, criticalProblem.solvedBy);
    }
  }
}