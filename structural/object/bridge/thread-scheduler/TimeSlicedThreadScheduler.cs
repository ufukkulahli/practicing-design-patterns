namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public sealed class TimeSlicedThreadScheduler : ThreadScheduler
  {
    private OSSpecificThreadScheduler ossts;
    public TimeSlicedThreadScheduler(OSSpecificThreadScheduler ossts) => this.ossts = ossts;
    public bool Start() => this.ossts.Start();
  }
}
