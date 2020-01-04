using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public class ThreadSchedulerUnitTests
  {
    [Fact]
    public void PreemtiveThreadSchedulerForWindowsImplementation()
    {
      // Arrange
      OSSpecificThreadScheduler ossts = new WindowsTS();
      ThreadScheduler ts = new PreemtiveThreadScheduler(ossts);

      // Act
      var started = ts.Start();

      // Assert
      Assert.True(started);
    }

    [Fact]
    public void TimeSlicedThreadSchedulerForWindowsImplementation()
    {
      // Arrange
      OSSpecificThreadScheduler ossts = new WindowsTS();
      ThreadScheduler ts = new TimeSlicedThreadScheduler(ossts);

      // Act
      var started = ts.Start();

      // Assert
      Assert.True(started);
    }

    [Fact]
    public void TimeSlicedThreadSchedulerForLinuxImplementation()
    {
      // Arrange
      OSSpecificThreadScheduler ossts = new LinuxTS();
      ThreadScheduler ts = new TimeSlicedThreadScheduler(ossts);

      // Act
      var started = ts.Start();

      // Assert
      Assert.False(started);
    }
  }
}
