namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public sealed class WindowsTS : OSSpecificThreadScheduler
  {
    public bool Start() => true;
  }
}
