using System.Linq;
using System.Text.RegularExpressions;

namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public class Rgex
  {
    private static readonly Regex WordExpression = new Regex("[^ .,']+");

    public static string[] SplitWords(string sentence)
    {
      return WordExpression.Matches(sentence ?? "").Select(match => match.Value).ToArray();
    }
  }
}
