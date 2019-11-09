namespace practicing_design_patterns.behavioral.@object.command.bulb
{
  public sealed class TurnOff : Command
  {
    private Bulb bulb;
    public TurnOff(Bulb bulb) => this.bulb = bulb;
    public void Execute() => this.bulb.TurnOff();
  }
}
