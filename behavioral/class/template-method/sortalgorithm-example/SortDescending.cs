using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@class
{
  internal class SortDescending : Sort
  {
    protected override void Compare()
    {
      Console.WriteLine("Comparing items for descended sorting...");
    }
    
    protected internal IEnumerable<string> GetItems()
    {
      return new List<string>{"C","B","A"};
    }
  }
}