using System;

namespace practicing_design_patterns.behavioral.@class
{
  public class VeggieSandwich : Sandwich
  {
    protected override Sandwich AddMainIngredient()
    {
      Console.WriteLine("Adding vegetables as main ingredient to sandwich...");
      return this;
    }
  }
}