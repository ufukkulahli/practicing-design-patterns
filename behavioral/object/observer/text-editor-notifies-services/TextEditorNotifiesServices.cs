using Xunit;

namespace practicing_design_patterns.behavioral.@object.observer.editor_notifies_services
{
  public class TextEditorNotifiesServices
  {
    [Fact]
    public void NotifyOtherServicesWhenAnEventOccurs()
    {
      // Arrange
      EventListener loggingListener = new LoggingListener();
      EventListener emailAlertListener = new EmailAlertListener();
      var textEditor = new TextEditor();
      textEditor.SubscribeEventListener(loggingListener);
      textEditor.SubscribeEventListener(emailAlertListener);

      // Act
      textEditor.OpenFile();

      // Assert

    }
  }
}
