namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal abstract class Participant : IParticipant
  {
    internal protected Account Account;
    internal MediatorCompany Company { get; set; } 
    public string Name;

    protected Participant(Account account, string name)
    {
      Account = account;
      Name = name;
    }

    internal protected void Send(Participant to, Amount amount)
    {
      this.Company.Transfer(this, to, amount);
    }
  }
}