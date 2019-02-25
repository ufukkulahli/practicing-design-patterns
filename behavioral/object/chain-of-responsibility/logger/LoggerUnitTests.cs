using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.logger
{
  public class LoggerUnitTests
  {
    public static ITestOutputHelper TestOutputHelper;

    public LoggerUnitTests(ITestOutputHelper testOutputHelper)
    {
      TestOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test()
    {
      // Arrange
      Logger logger, logger1, logger2;
      logger = new ConsoleLogger(LogLevel.All);
      logger1 = logger.SetNext(new EmailLogger(LogLevel.FunctionalMessage | LogLevel.FunctionalError));
      logger2 = logger1.SetNext(new FileLogger(LogLevel.Warning | LogLevel.Error));

      // Act
      logger.Message("This message will be handled by consoleLogger", LogLevel.Debug);
      logger.Message("This message will be handled by consoleLogger", LogLevel.Info);

      logger.Message("This message will be handled by consoleLogger and fileLogger", LogLevel.Warning);
      logger.Message("This message will be handled by consoleLogger and fileLogger", LogLevel.Error);

      logger.Message("This message will be handled by consoleLogger and emailLogger", LogLevel.FunctionalError);
      logger.Message("This message will be handled by consoleLogger and emailLogger", LogLevel.FunctionalMessage);
    }
  }
}