namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public interface EventListener
  {
    void Notify(string eventData);
    string LastEventData {get;}
  }
}
