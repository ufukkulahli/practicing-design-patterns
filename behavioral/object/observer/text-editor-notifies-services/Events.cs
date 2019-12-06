using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class Events
  {
    private readonly IDictionary<Type, EventListener> listeners
      = new Dictionary<Type, EventListener>();

    public void Subscribe(EventListener listener)
    {
      this.listeners.Add(listener.GetType(), listener);
    }
  }
}
