using System;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class LoggingListener : EventListener
  {
    public string LastEventData {get; private set;} = string.Empty;

    public void Notify(string eventData)
    {
      Console.WriteLine("Logging the " + eventData + " to the console.");
      this.LastEventData = eventData;
    }
  }
}
