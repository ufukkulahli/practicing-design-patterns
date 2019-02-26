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
    public void LoggersShouldHandleMessagesByTheirLogLevelMask()
    {
      // Arrange
      var logger = new ConsoleLogger(LogLevel.All);
      var logger1 = logger.SetNext(new EmailLogger(LogLevel.FunctionalMessage | LogLevel.FunctionalError));
      var logger2 = logger1.SetNext(new FileLogger(LogLevel.Warning | LogLevel.Error));

      // Act
      logger.Message("This message will be handled by consoleLogger", LogLevel.Debug);
      logger.Message("This message will be handled by consoleLogger", LogLevel.Info);

      logger.Message("This message will be handled by consoleLogger and fileLogger", LogLevel.Warning);
      logger.Message("This message will be handled by consoleLogger and fileLogger", LogLevel.Error);

      logger.Message("This message will be handled by consoleLogger and emailLogger", LogLevel.FunctionalError);
      logger.Message("This message will be handled by consoleLogger and emailLogger", LogLevel.FunctionalMessage);
      
      // Assert
      Assert.IsType<ConsoleLogger>(logger);
      Assert.IsType<EmailLogger>(logger1);
      Assert.IsType<FileLogger>(logger2);
      
      Assert.True(logger.LogMask == LogLevel.All);
      Assert.True(logger1.LogMask == (LogLevel.FunctionalMessage | LogLevel.FunctionalError));
      Assert.True(logger2.LogMask == (LogLevel.Warning | LogLevel.Error));
    }
  }
}