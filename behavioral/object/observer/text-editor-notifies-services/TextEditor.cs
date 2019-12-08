namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class TextEditor
  {
    private readonly Events events = new Events();
    public void SubscribeEventListener(string eventType, EventListener eventListener) =>
      this.events.Subscribe(eventType, eventListener);
    public void OpenFile()
    {
      // Open file dialog shows up...
      this.events.Notify("openFile", "HelloWorld.txt");
    }
  }
}
