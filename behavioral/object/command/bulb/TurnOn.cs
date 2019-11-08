namespace practicing_design_patterns.behavioral.@object.command.bulb
{
  public sealed class TurnOn : Command
  {
    private readonly Bulb bulb;
    public TurnOn(Bulb bulb) => this.bulb = bulb;
    public void Execute() => this.bulb.TurnOn();
  }
}
