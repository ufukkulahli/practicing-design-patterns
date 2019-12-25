namespace practicing_design_patterns.structural.@object.bridge.product
{
  public sealed class OffState : IState
  {
    public string Change() => "Current device's state is OFF now.";
  }
}
