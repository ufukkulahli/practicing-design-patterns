using System;

namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class RandomPosition
  {
    private readonly Random random = new Random();
    public override string ToString() => this.Generate();
    public string Generate() => this.random.Next() + "x" + this.random.Next();
  }
}
