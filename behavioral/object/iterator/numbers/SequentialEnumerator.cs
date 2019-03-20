using System.Collections;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  internal class SequentialEnumerator : IEnumerator<int>
  {
    private int index;
    private List<int> numbers;
    public int Current { get; private set; }

    object IEnumerator.Current => Current;

    public void Dispose() => throw new System.NotImplementedException();

    private bool HasNext() => this.numbers.Count > this.index;

    public SequentialEnumerator(Numbers numbers)
    {
      this.numbers = numbers.numbers;
      this.index = 0;
    }

    public bool MoveNext()
    {
      if (this.HasNext())
      {
        this.Current = this.numbers[this.index++];
        return true;
      }

      return false;
    }

    public void Reset()
    {
      this.index = 0;
      this.Current = 0;
    }
  }
}