namespace practicing_design_patterns.behavioral.@object.mediator.chat
{
  public interface IMediator
  {
    void Register(Friend friend);
    void Send(Friend friend, string message);
  }
}
