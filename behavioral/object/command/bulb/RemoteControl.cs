namespace practicing_design_patterns.behavioral.@object.command.bulb
{
  public sealed class RemoteControl
  {
    public void Submit(Command command) => command.Execute();
  }
}
