using System;

namespace practicing_design_patterns.behavioral.@class
{
  internal class Coffee : Beverage
  {
    protected override void Brew()
    {
      Console.WriteLine("Adding coffee grounds to water...");
    }

    protected override void AddCondiments()
    {
      Console.WriteLine("Adding milk...");
    }
  }
}