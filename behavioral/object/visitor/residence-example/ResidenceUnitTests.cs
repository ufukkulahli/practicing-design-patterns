using Xunit;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class ResidenceUnitTests
  {
    [Fact]
    public void MaidVisitsResidence()
    {
      // Arrange
      IResidenceVisitor maid = new Maid();
      IRoom bathroom = new Bathroom();
      IRoom bedroom = new Bedroom();
      IRoom kitchen = new Kitchen();
      IRoom livingRoom = new LivingRoom();

      // Act
      bathroom.Accept(maid);
      bedroom.Accept(maid);
      kitchen.Accept(maid);
      livingRoom.Accept(maid);
    }

    [Fact]
    public void PlumberVisitsResidence()
    {
      // Arrange
      IResidenceVisitor plumber = new Plumber();
      IRoom bathroom = new Bathroom();
      IRoom bedroom = new Bedroom();
      IRoom kitchen = new Kitchen();
      IRoom livingRoom = new LivingRoom();

      // Act
      bathroom.Accept(plumber);
      bedroom.Accept(plumber);
      kitchen.Accept(plumber);
      livingRoom.Accept(plumber);
    }
  }
}