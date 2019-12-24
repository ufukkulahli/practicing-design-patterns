namespace practicing_design_patterns.structural.@object.bridge.product
{
  public sealed class OnState : IState
  {
    public string Change() => "Current device's state is ON now.";
  }
}
