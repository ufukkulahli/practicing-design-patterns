using System;
using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class Events
  {
    private readonly IDictionary<string, EventListener> listeners
      = new Dictionary<string, EventListener>();

    public void Subscribe(EventListener listener)
    {
      this.listeners.Add(listener.EventType, listener);
    }

    internal void Notify(string eventData)
    {
      var listenersToBeNotified = this.listeners
                                        .Where(l => l.Key == "open")
                                        .Select(l=>l.Value)
                                        .ToList();

      foreach (var listener in listenersToBeNotified)
      {
        listener.Notify(eventData);
      }
    }
  }
}
