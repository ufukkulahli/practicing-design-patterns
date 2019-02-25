namespace practicing_design_patterns.behavioral.@object.logger
{
  public class FileLogger : Logger
  {
    public FileLogger(LogLevel logMask) : base(logMask)
    {
    }

    protected override void WriteMessage(string message)
    {
      LoggerUnitTests.TestOutputHelper.WriteLine
        ("Writing message to log file. Message is: {0}", message);
    }
  }
}