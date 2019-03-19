using Xunit;

namespace practicing_design_patterns.behavioral.@object.iterator.numbers
{
  public class NumbersIteratorUnitTests
  {
    [Fact]
    public void TestThatEnumerationShouldBeSequental()
    {
      // Arrange
      var numbers = new Numbers(1, 2, 3, 4, 5);
      var enumerator = numbers.GetEnumerator();

      // Act
      Assert.True(enumerator.MoveNext());
      Assert.Equal(1, enumerator.Current);

      Assert.True(enumerator.MoveNext());
      Assert.Equal(2, enumerator.Current);

      Assert.True(enumerator.MoveNext());
      Assert.Equal(3, enumerator.Current);

      Assert.True(enumerator.MoveNext());
      Assert.Equal(4, enumerator.Current);

      Assert.True(enumerator.MoveNext());
      Assert.Equal(5, enumerator.Current);
    }
  }
}