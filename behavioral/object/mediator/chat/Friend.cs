namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public abstract class Friend
  {
    protected IMediator mediator;
    public string Name {get; protected set;}
    
    public Friend(IMediator mediator)
    {
      this.mediator = mediator;
    }
  }
}
