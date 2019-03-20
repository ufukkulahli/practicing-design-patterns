using System.Collections.Generic;
using Xunit;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  public class NumbersIteratorUnitTests
  {
    [Fact]
    public void TestThatEnumerationShouldBeSequentialAndReversed()
    {
      // Arrange
      var numbers = new List<int>() {1, 2, 3, 4, 5};
      var sequentialNumbers = new SequentialNumbers(numbers);
      var sequentialEnumerator = sequentialNumbers.GetEnumerator();

      var reverseNumbers = new ReverseNumbers(numbers);
      var reverseEnumerator = reverseNumbers.GetEnumerator();
      
      // Act & Assert
      Assert.True(sequentialEnumerator.MoveNext());
      Assert.Equal(1, sequentialEnumerator.Current);

      Assert.True(reverseEnumerator.MoveNext());
      Assert.Equal(5, reverseEnumerator.Current);
      
      Assert.True(sequentialEnumerator.MoveNext());
      Assert.Equal(2, sequentialEnumerator.Current);

      Assert.True(reverseEnumerator.MoveNext());
      Assert.Equal(4, reverseEnumerator.Current);
      
      Assert.True(sequentialEnumerator.MoveNext());
      Assert.Equal(3, sequentialEnumerator.Current);

      Assert.True(reverseEnumerator.MoveNext());
      Assert.Equal(3, reverseEnumerator.Current);
     
      Assert.True(sequentialEnumerator.MoveNext());
      Assert.Equal(4, sequentialEnumerator.Current);

      Assert.True(reverseEnumerator.MoveNext());
      Assert.Equal(2, reverseEnumerator.Current);
     
      Assert.True(sequentialEnumerator.MoveNext());
      Assert.Equal(5, sequentialEnumerator.Current);
     
      Assert.True(reverseEnumerator.MoveNext());
      Assert.Equal(1, reverseEnumerator.Current);
    }
  }
}