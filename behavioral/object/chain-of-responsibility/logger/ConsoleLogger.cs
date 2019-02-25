namespace practicing_design_patterns.behavioral.@object.logger
{
  public class ConsoleLogger : Logger
  {
    public ConsoleLogger(LogLevel logMask) : base(logMask)
    {
    }

    protected override void WriteMessage(string message)
    {
      LoggerUnitTests.TestOutputHelper.WriteLine
        ("Writing message to console. Message is: {0}", message);
    }
  }
}