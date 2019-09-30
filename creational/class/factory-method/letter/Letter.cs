using System;
using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.creational.@class.factory_method.letter
{
  public abstract class Letter
  {
    private static readonly IEnumerable<char> vowels =
      new List<char>(){'a','e','i','o','u','A','E','I','O','U'};

    public static Letter New(char c)
    {
      throw new Exception();
      
      if(vowels.Contains(c))
      {
        //return new Vowel(c);
      }
      //return new Consonant(c);
    }
  }
}
