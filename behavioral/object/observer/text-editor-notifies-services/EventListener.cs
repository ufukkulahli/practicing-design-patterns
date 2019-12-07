namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public interface EventListener
  {
    string EventType {get;}
    void Notify(string eventData);
  }
}
