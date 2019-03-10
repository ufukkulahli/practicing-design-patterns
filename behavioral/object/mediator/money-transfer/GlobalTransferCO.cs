using System.Collections.Generic;
using static practicing_design_patterns.behavioral.@object.mediator.moneytransfer.MoneyTransferUnitTests;

namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal sealed class GlobalTransferCO : MediatorCompany
  {
    private protected override ICollection<Participant> Participants { get; }
      = new List<Participant>();

    public IReadOnlyCollection<Participant> ViewRegisteredParticipants()
    {
      return this.Participants as IReadOnlyCollection<Participant>;
    }

    protected internal override void Transfer(Participant from, Participant to, Amount amount)
    {
      if (!this.Participants.Contains(from) || !this.Participants.Contains(to))
      {
        throw new ParticipantNotFoundException(to);
      }

      to.Account.Balance.Increase(amount);
      OutputHelper
        .WriteLine("{0} sent to {1} {2}", from.Name, to.Name, amount);
    }

    internal protected override void Register(params Participant[] participants)
    {
      foreach (var participant in participants)
      {
        if (this.Participants.Contains(participant))
        {
          return;
        }

        participant.Company = this;
        this.Participants.Add(participant);
        OutputHelper
          .WriteLine("Registered participant with name: {0}", participant.Name);
      }
    }
  }
}