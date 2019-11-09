using System;

namespace practicing_design_patterns.behavioral.@object.command.bulb
{
  public sealed class Bulb
  {
    private bool isOn;
    internal bool IsOn() => this.isOn;
    public void TurnOn()
    {
      this.isOn = true;
      Console.WriteLine("Turned on the bulb.");
    }
    public void TurnOff()
    {
      this.isOn = false;
      Console.WriteLine("Turned off the bulb.");
    }
  }
}
