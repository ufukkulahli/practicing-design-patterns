using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public class ThreadSchedulerUnitTests
  {
    [Fact]
    public void WindowsThreadScheduler()
    {
      // Arrange
      ThreadScheduler ts = new PreemtiveThreadScheduler();

      // Act

      // Assert

    }
  }
}
