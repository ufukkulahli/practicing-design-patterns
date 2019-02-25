namespace practicing_design_patterns.behavioral.@object.printer
{
  public class FaxErrorHandler : IReceiver
  {
    private readonly IReceiver _receiver;
    internal bool IsHandled { get; private set; }

    public FaxErrorHandler(IReceiver receiver)
    {
      _receiver = receiver;
    }

    public bool HandleMessage(Message message)
    {
      if (message.Text.Contains("Email"))
      {
        PrinterUnitTests.TestOutputHelper.WriteLine
          ("FaxErrorHandler processed {0} priority issue: {1}", message.Priority, message.Text);
        this.IsHandled = true;
        return true;
      }

      _receiver?.HandleMessage(message);
      return false;
    }
  }
}