namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public sealed class TextEditor
  {
    private readonly Events events = new Events();
    public void SubscribeEventListener(string eventType, EventListener eventListener) =>
      this.events.Subscribe(eventType, eventListener);
    public void UnsubscribeEventListener(string eventType, EventListener eventListener) =>
      this.events.Unsubscribe(eventType, eventListener);

    // Open file dialog shows up...
    public void OpenFile() => this.events.Notify("openFile", "HelloWorld.txt");
    public void SaveFile() => this.events.Notify("saveFile", "HelloWorld.txt");
  }
}
