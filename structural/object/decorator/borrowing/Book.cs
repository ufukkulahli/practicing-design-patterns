namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  class Book : LibraryItem
  {
    readonly string author;
    readonly string title;

    Book(string author, string title, int numberOfCopies)
    {
      this.author=author;
      this.title=title;
      base.NumberOfCopies=numberOfCopies;
    }

    public override void Display()
    {
     //TODO:
     //Borrowing.TestOutputHelper.WriteLine("Book:");
     //Borrowing.TestOutputHelper.WriteLine("Author: {0}", this.author);
     //Borrowing.TestOutputHelper.WriteLine("Title: {0}", this.title);
     //Borrowing.TestOutputHelper.WriteLine("Number of copies: {0}", base.NumberOfCopies);
    }
  }
}
