using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public abstract class LetterComposite
  {
    private readonly ICollection<LetterComposite> children = new List<LetterComposite>();
    protected virtual void PrintThisBefore(){}
    protected virtual void PrintThisAfter(){}
    public void Add(LetterComposite letter) => this.children.Add(letter); 
    public int Count() => this.children.Count;
    public void Print()
    {
      this.PrintThisBefore();
      foreach(var letter in this.children)
      {
        letter.Print();
      }
      this.PrintThisAfter();
    }
  }
}
