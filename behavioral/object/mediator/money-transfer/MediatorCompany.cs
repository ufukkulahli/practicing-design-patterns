namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal abstract class MediatorCompany : IMediator
  {
    protected abstract void Register(Participant participant);
    protected abstract void Send(Participant participant);
  }
}