using System;

namespace practicing_design_patterns.behavioral.@class
{
  internal class Tea : Beverage
  {
    protected override void Brew()
    {
      Console.WriteLine("Adding tea leaves to water...");
    }

    protected override void AddCondiments()
    {
      Console.WriteLine("Adding sugar...");
      Sugar();
    }

    private new void Sugar()
    {
      Console.WriteLine($"Adding {base.sugar} spoons of sugar...");
    }

    public new int AddSugar
    {
      set { sugar = value; }
    }
  }
}