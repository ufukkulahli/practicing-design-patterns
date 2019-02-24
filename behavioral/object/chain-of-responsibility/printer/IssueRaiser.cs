namespace practicing_design_patterns.behavioral.@object.printer
{
  public class IssueRaiser
  {
    private readonly IReceiver firstReceiver;

    public IssueRaiser(IReceiver firstReceiver)
    {
      this.firstReceiver = firstReceiver;
    }

    public void Raise(Message message)
    {
      firstReceiver?.HandleMessage(message);
    }
  }
}