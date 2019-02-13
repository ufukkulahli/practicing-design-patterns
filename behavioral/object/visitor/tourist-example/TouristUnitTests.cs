using Xunit;

namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  public class TouristUnitTests
  {
    [Fact]
    public void TouristVisitsMuseum()
    {
      // Arrange
      IVisitor tourist = new Tourist();
      IVisitee museum = new Museum();

      // Act
      museum.Accept(tourist);
    }

    [Fact]
    public void TouristVisitsTheater()
    {
      // Arrange
      IVisitor tourist = new Tourist();
      IVisitee theater = new Theater();

      // Act
      theater.Accept(tourist);
    }
  }
}