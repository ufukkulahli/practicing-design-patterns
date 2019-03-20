using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  sealed class ReverseNumbers : Numbers
  {
    public ReverseNumbers(List<int> numbers) : base(numbers)
    {
    }

    public override IEnumerator<int> GetEnumerator()
    {
      return new ReverseEnumerator(this);
    }
  }
}