using System.Collections;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  internal class ReverseEnumerator : IEnumerator<int>
  {
    private int index;
    private List<int> numbers;
    public int Current { get; private set; }

    object IEnumerator.Current => Current;

    public void Dispose() => throw new System.NotImplementedException();

    private bool HasNext()
    {
      return this.index <= this.numbers.Count;
    }

    public ReverseEnumerator(Numbers numbers)
    {
      this.numbers = numbers.numbers;
      this.index = this.numbers.Count-1;
    }

    public bool MoveNext()
    {
      if (this.HasNext())
      {
        this.Current = this.numbers[this.index--];
        return true;
      }

      return false;
    }

    public void Reset()
    {
      this.index = this.numbers.Count;
      this.Current = this.numbers[this.index];
    }
  }
}