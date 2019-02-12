using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@class
{
  internal class SortAscending : Sort
  {
    protected override void Compare()
    {
      Console.WriteLine("Comparing items for ascending sorting...");
    }

    protected IEnumerable<string> GetItems()
    {
      return new List<string>{"A","B","C"};
    }
  }
}