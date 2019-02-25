namespace practicing_design_patterns.behavioral.@object.printer
{
  public class EmailErrorHandler : IReceiver
  {
    private readonly IReceiver _receiver;
    internal bool IsHandled { get; private set; }

    public EmailErrorHandler(IReceiver receiver)
    {
      _receiver = receiver;
    }

    public bool HandleMessage(Message message)
    {
      if (message.Text.Contains("Fax"))
      {
        PrinterUnitTests.TestOutputHelper.WriteLine
          ("EmailErrorHandler processed {0} priority issue: {1}", message.Priority, message.Text);
        this.IsHandled = true;
        return true;
      }

      _receiver?.HandleMessage(message);
      return false;
    }
  }
}