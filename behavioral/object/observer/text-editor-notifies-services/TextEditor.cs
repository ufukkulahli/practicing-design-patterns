namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class TextEditor
  {
    private readonly Events events;
    public void SubscribeEventListener(EventListener loggingListener) =>
      this.events.Subscribe(loggingListener);
    public void OpenFile() => this.events.Notify();
  }
}
