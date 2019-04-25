namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  class Book : LibraryItem
  {
    readonly string author;
    readonly string title;

    internal Book(string author, string title, int numberOfCopies)
    {
      this.author=author;
      this.title=title;
      base.NumberOfCopies=numberOfCopies;
    }

    public override void Display()
    {
     BorrowingUnitTests.TestOutputHelper.WriteLine("Book:");
     BorrowingUnitTests.TestOutputHelper.WriteLine("Author: {0}", this.author);
     BorrowingUnitTests.TestOutputHelper.WriteLine("Title: {0}", this.title);
     BorrowingUnitTests.TestOutputHelper.WriteLine("Number of copies: {0}", base.NumberOfCopies);
    }
  }
}
