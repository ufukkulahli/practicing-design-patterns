using System;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class EmailAlertListener : EventListener
  {
    public string LastEventData { get; private set; }

    public void Notify(string eventData)
    {
      Console.WriteLine("Sending the " + eventData + " via e-mail.");
      // Send e-mail.
      this.LastEventData = eventData;
    }
  }
}
