using System;

namespace practicing_design_patterns.behavioral.@class.template
{
  public abstract class Sandwich
  {
    private Sandwich LayBread()
    {
      Console.WriteLine("Laying down the bread,");
      return this;
    }

    private Sandwich AddLettuce()
    {
      Console.WriteLine("Adding some lettuce,");
      return this;
    }

    private Sandwich AddSauces()
    {
      Console.WriteLine("Adding some sauces,");
      return this;
    }

    protected abstract Sandwich AddMainIngredient();

    protected internal Sandwich Make()
    {
      Console.WriteLine("Making sandwich is in progress...");
      return this
        .LayBread()
        .AddLettuce()
        .AddMainIngredient()
        .AddSauces();
    }
  }
}