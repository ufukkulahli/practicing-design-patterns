namespace practicing_design_patterns.behavioral.@object.logger
{
  public class EmailLogger : Logger
  {
    public EmailLogger(LogLevel logMask) : base(logMask)
    {
    }

    protected override void WriteMessage(string message)
    {
      LoggerUnitTests.TestOutputHelper.WriteLine
        ("Sending message via email. Message is: {0}", message);
    }
  }
}