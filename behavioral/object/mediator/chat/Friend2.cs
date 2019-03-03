namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public class Friend2 : Friend
  {
    public Friend2(IMediator mediator, string name) : base(mediator)
    {
      this.Name = name;
    }

    public void Send(string message)
    {
      base.mediator.Send(this, message);
    }
  }
}
