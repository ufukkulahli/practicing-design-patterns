namespace PracticingDesignPatterns.Behavioral.Class.Template
{
  public class MeatSandwich : Sandwich
  {
    protected Sandwich AddMainIngredient()
    {
      Console.WriteLine("Adding meat as main ingredient to sandwich...");
      return this;
    }
  }
}