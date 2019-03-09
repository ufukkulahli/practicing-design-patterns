namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal abstract class Participant : IParticipant
  {
    internal protected abstract Account Account();
    internal MediatorCompany Company { get; set; }
  }
}