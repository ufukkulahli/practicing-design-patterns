using System;

namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal class ParticipantNotFoundException : Exception
  {
    public ParticipantNotFoundException(Participant to)
    {
      MoneyTransferUnitTests.OutputHelper
        .WriteLine("Receiver name {0} could not be found!", to.Name);
    }
  }
}