using System;

namespace practicing_design_patterns.behavioral.@class
{
  public abstract class Sort
  {
    private void DoSomeInternalOperationsOnItems()
    {
      Console.WriteLine("Processing items...");
    }

    private void DoSomeOtherInternalOperationsOnItems()
    {
      Console.WriteLine("Processing items...");
    }
    
    protected abstract void Compare();
    
    public void DoSort()
    {
      this.DoSomeInternalOperationsOnItems();
      this.DoSomeOtherInternalOperationsOnItems();
      this.Compare();
    }
  }
}