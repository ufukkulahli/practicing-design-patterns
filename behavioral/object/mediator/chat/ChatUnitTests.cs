using System;
using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public class ChatUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public ChatUnitTests(ITestOutputHelper outputHelper)
    {
      OutputHelper = outputHelper;
    }

    [Fact]
    public void TestThatOnlyFriendsChatEachOther()
    {
      // Arrange
      var mediator = new Mediator();
      Friend1 john = new Friend1(mediator, "John");
      Friend2 jane = new Friend2(mediator, "Jane");
      Boss sam = new Boss(mediator, "Sam");
      Unknown unknown = new Unknown(mediator, "Jack");

      mediator.Register(john);
      mediator.Register(jane);
      mediator.Register(sam);
      mediator.DisplayDetails();
      
      // Act
      john.Send("Hi Jane!");
      jane.Send("Hi John! What's up?");
      sam.Send("Chit-chat later please!");
      unknown.Send("Hello people!");

      // Assert
      // TODO: ADD ASSERTS
    }
  }
}
