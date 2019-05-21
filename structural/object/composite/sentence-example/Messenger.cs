using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public sealed class Messenger
  {
    public LetterComposite ComposeHelloWorld()
    {
      var letterCollection1 = new List<Letter>()
      {
        new Letter('h'),
        new Letter('e'),
        new Letter('l'),
        new Letter('l'),
        new Letter('o')
      };
      var hello = new Word(letterCollection1);

      var letterCollection2 = new List<Letter>()
      {
        new Letter('w'),
        new Letter('o'),
        new Letter('r'),
        new Letter('l'),
        new Letter('d')
      };
      var world = new Word(letterCollection2);

      var words = new List<Word>()
      {
        hello,
        world
      };

      return new Sentence(words);
    }
  }
}
