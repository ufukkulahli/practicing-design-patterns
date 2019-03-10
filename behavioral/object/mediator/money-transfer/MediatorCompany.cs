using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal abstract class MediatorCompany : IMediator
  {
    private protected abstract ICollection<Participant> Participants { get; }
    internal protected abstract void Register(params Participant[] participant);
    protected internal abstract void Transfer(Participant from, Participant to, Amount amount);
  }
}