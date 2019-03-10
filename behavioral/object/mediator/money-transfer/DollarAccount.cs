namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  internal sealed class DollarAccount : Account
  {
    protected internal override Balance Balance { get; protected set; } = Balance.Zero;
  }
}