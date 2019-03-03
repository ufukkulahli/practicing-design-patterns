namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public class Friend1 : Friend
  {
    public Friend1(IMediator mediator, string name) : base(mediator)
    {
      this.Name = name;
    }

    public void Send(string message)
    {
      base.mediator.Send(this, message);
    }
  }
}
