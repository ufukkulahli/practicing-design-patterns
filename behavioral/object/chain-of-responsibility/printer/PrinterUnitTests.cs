using Xunit;

namespace practicing_design_patterns.behavioral.@object.printer
{
  public class PrinterUnitTests
  {
    [Fact]
    public void ErrorHandlers_Should_Handle_AllErrors()
    {
      // Arrange
      var message1 = new Message(Priority.Normal, "Fax is reaching late to the destination.");
      var message2 = new Message(Priority.High, "Emails are not reaching to destinations.");
      var message3 = new Message(Priority.Normal, "In Email, CC field is disabled always.");
      var message4 = new Message(Priority.High, "Fax is not reaching destination.");

      var emailHandler = new EmailErrorHandler(null);
      var faxhandler = new FaxErrorHandler(emailHandler);
      var issueRaiser = new IssueRaiser(faxhandler);

      // Act
      issueRaiser.Raise(message1);
      issueRaiser.Raise(message2);
      issueRaiser.Raise(message3);
      issueRaiser.Raise(message4);

      // Assert
      Assert.True(emailHandler.IsHandled);
      Assert.True(faxhandler.IsHandled);
    }
  }
}