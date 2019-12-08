using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class Events
  {
    private readonly List<KeyValuePair<string, EventListener>> listeners
      = new List<KeyValuePair<string, EventListener>>();

    public void Subscribe(string eventType, EventListener listener)
    {
      this.listeners.Add(new KeyValuePair<string, EventListener>(eventType, listener));
    }

    public void Notify(string eventType, string eventData)
    {
      foreach (var listener in ListenersToBeNotified(eventType))
      {
        listener.Notify(eventData);
      }
    }

    private IEnumerable<EventListener> ListenersToBeNotified(string eventType)
    {
      return this.listeners
                  .Where(l => l.Key == eventType)
                  .Select(l => l.Value);
    }
  }
}
