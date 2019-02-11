using System;

namespace practicing_design_patterns.behavioral.@class
{
  public abstract class Beverage
  {
    private void Boil()
    {
      Console.WriteLine("Boiling water...");
    }

    private void Pour()
    {
      Console.WriteLine("Pouring in cup...");
    }

    internal bool WantsCondiments { private get; set; }
    
    protected int sugar;
    protected void Sugar() { }

    protected abstract void Brew();
    protected abstract void AddCondiments();
    
    public int AddSugar { get; set; }

    public Beverage Prepare()
    {
      this.Boil();
      this.Brew();
      this.Pour();
      if (this.WantsCondiments)
      {
        this.AddCondiments();
      }
      return this;
    }
  }
}