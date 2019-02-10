using System;

namespace practicing_design_patterns.behavioral.@class.template
{
  public class MeatSandwich : Sandwich
  {
    protected override Sandwich AddMainIngredient()
    {
      Console.WriteLine("Adding meat as main ingredient to sandwich...");
      return this;
    }
  }
}