using System;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  class Borrowable : Decorator
  {
    protected IEnumerable<string> borrowers = new List<string>();
    public Borrowable(LibraryItem libraryItem):base(libraryItem){}
    public void BorrowItem(string name)
    {
      this.borrowers.Add(name);
      base.libraryItem.NumberOfCopies--;
    }
    public void ReturnItem(string name)
    {
      this.borrowers.Remove(name);
      base.libraryItem.NumberOfCopies++;
    }
    public override void Display()
    {
      base.Display();
      foreach(var borrower in borrowers)
      {
        //Borrowing.TestOutputHelper.WriteLine("Video:");
      }
    }
  }
}
