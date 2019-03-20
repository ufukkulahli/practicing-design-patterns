using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  sealed class SequentialNumbers : Numbers
  {
    public SequentialNumbers(List<int> numbers) : base(numbers)
    {
    }

    public override IEnumerator<int> GetEnumerator()
    {
      return new SequentialEnumerator(this);
    }
  }
}