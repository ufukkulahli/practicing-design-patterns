using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public class ThreadSchedulerUnitTests
  {
    [Fact]
    public void WindowsThreadScheduler()
    {
      // Arrange
      OSSpecificThreadScheduler ossts = new WindowsTS();
      ThreadScheduler ts = new PreemtiveThreadScheduler(ossts);

      // Act
      var started = ts.Start();

      // Assert
      Assert.True(started);
    }
  }
}
