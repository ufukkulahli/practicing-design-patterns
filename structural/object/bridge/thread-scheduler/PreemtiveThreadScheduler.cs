namespace practicing_design_patterns.structural.@object.bridge.thread_scheduler
{
  public sealed class PreemtiveThreadScheduler : ThreadScheduler
  {
    private OSSpecificThreadScheduler ossts;
    public PreemtiveThreadScheduler(OSSpecificThreadScheduler ossts) => this.ossts = ossts;
    public bool Start() => this.ossts.Start();
  }
}
