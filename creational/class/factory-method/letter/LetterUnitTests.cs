using Xunit;

namespace practicing_design_patterns.creational.@class.factory_method.letter
{
  public class LetterUnitTests
  {
    [Fact]
    public void GivenLetterIsVowel()
    {
      // ARRANGE
      Letter letter = Letter.New('a');

      // ACT
      var isVowel = letter.IsVowel();

      // ASSERT
      Assert.True(isVowel);
    }

    [Fact]
    public void GivenLetterIsConsonant()
    {
      // ARRANGE
      Letter letter = Letter.New('t');

      // ACT
      var isConsonant = letter.IsConsonant();

      // ASSERT
      Assert.True(isConsonant);
    }
  }
}
