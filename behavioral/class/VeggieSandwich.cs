namespace PracticingDesignPatterns.Behavioral.Class.Template
{
  public class VeggieSandwich : Sandwich
  {
    protected Sandwich AddMainIngredient()
    {
      Console.WriteLine("Adding vegetables as main ingredient to sandwich...");
      return this;
    }
  }
}