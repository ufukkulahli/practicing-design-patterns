using System;
using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.creational.@class.factory_method.letter
{
  public abstract class Letter
  {
    private static readonly IEnumerable<char> vowels =
      new List<char>(){'a','e','i','o','u','A','E','I','O','U'};

    public abstract bool IsVowel();
    public abstract bool IsConsonant();

    public static Letter New(char letter)
    {
      if(vowels.Contains(letter))
      {
        return new Vowel(letter);
      }
      return new Consonant(letter);
    }

    private sealed class Vowel : Letter
    {
      private char letter;
      public Vowel(char letter) => this.letter = letter;
      public override bool IsVowel() => true;
      public override bool IsConsonant() => false;
    }

    private sealed class Consonant : Letter
    {
      private char letter;
      public Consonant(char letter) => this.letter = letter;
      public override bool IsVowel() => false;
      public override bool IsConsonant() => true;
    }
  }
}
