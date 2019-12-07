namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class LoggingListener : EventListener
  {
    public string EventType => "open file";

    public void Notify(string eventData)
    {
      throw new System.NotImplementedException();
    }
  }
}
