using Xunit;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public class TextEditorNotifiesServices
  {
    [Fact]
    public void NotifyOtherServicesWhenOpenFileEventOccurs()
    {
      // Arrange
      EventListener loggingListener = new LoggingListener();
      EventListener emailAlertListener = new EmailAlertListener();
      var textEditor = new TextEditor();
      textEditor.SubscribeEventListener("openFile", loggingListener);
      textEditor.SubscribeEventListener("openFile", emailAlertListener);

      // Act
      textEditor.OpenFile();

      // Assert
      Assert.Equal("HelloWorld.txt", loggingListener.LastEventData);
      Assert.Equal("HelloWorld.txt", emailAlertListener.LastEventData);
    }

    [Fact]
    public void NotifyOtherServicesWhenSaveFileEventOccurs()
    {
      // Arrange
      EventListener loggingListener = new LoggingListener();
      EventListener emailAlertListener = new EmailAlertListener();
      var textEditor = new TextEditor();
      textEditor.SubscribeEventListener("saveFile", loggingListener);
      textEditor.SubscribeEventListener("saveFile", emailAlertListener);
      // (Unsubscribe e-mail alert listener)
      textEditor.UnsubscribeEventListener("saveFile", emailAlertListener);

      // Act
      textEditor.SaveFile();

      // Assert
      Assert.Equal("HelloWorld.txt", loggingListener.LastEventData);
      Assert.Equal(string.Empty, emailAlertListener.LastEventData);
    }

    [Fact]
    public void NotifyOtherServicesWhenOpenAndSaveFileEventOccurs()
    {
      // Arrange
      EventListener loggingListener = new LoggingListener();
      EventListener emailAlertListener = new EmailAlertListener();
      var textEditor = new TextEditor();
      textEditor.SubscribeEventListener("saveFile", loggingListener);
      textEditor.SubscribeEventListener("openFile", emailAlertListener);

      // Act
      textEditor.SaveFile();
      textEditor.OpenFile();

      // Assert
      Assert.Equal("HelloWorld.txt", loggingListener.LastEventData);
      Assert.Equal("HelloWorld.txt", emailAlertListener.LastEventData);
    }
  }
}
