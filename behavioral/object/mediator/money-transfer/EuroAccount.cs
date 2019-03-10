namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal sealed class EuroAccount : Account
  {
    protected internal override Balance Balance { get; protected set; } = Balance.Zero;
  }
}