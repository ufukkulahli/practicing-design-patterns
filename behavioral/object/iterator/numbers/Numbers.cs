using System.Collections;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  public abstract class Numbers : IEnumerable<int>
  {
    internal List<int> numbers;

    public Numbers(List<int> numbers)
    {
      this.numbers = numbers;
    }

    public abstract IEnumerator<int> GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
  }
}