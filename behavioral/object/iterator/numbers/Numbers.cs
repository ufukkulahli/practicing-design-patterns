using System.Collections;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  public class Numbers : IEnumerable<int>
  {
    private List<int> numbers;

    public Numbers(params int[] numbers)
    {
      this.numbers = new List<int>(numbers);
    }

    public IEnumerator<int> GetEnumerator()
    {
      return new NumbersEnumerator(this.numbers);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    private class NumbersEnumerator : IEnumerator<int>
    {
      private int index;
      private List<int> numbers;

      public NumbersEnumerator(List<int> numbers)
      {
        this.numbers = numbers;
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

      private bool HasNext()
      {
        return
          this.numbers.Count > this.index;
      }

      public int Current { get; private set; }

      object IEnumerator.Current =>
        Current;

      public void Dispose() =>
        throw new System.NotImplementedException();
    }
  }
}