using System;

namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class ComputerBuilder
  {
    public ComputerBuilder Motherboard()
    {
      return this;
    }

    public Computer Build()
    {
      throw new NotImplementedException();
    }
  }
}