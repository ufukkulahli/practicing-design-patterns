namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  class Video : LibraryItem
  {
    readonly string director;
    readonly string title;
    readonly int playTime;

    internal Video(string director, string title, int playTime, int numberOfCopies)
    {
      this.director=director;
      this.title=title;
      this.playTime=playTime;
      base.NumberOfCopies=numberOfCopies;
    }

    public override void Display()
    {
     BorrowingUnitTests.TestOutputHelper.WriteLine("Video:");
     BorrowingUnitTests.TestOutputHelper.WriteLine("director: {0}", this.director);
     BorrowingUnitTests.TestOutputHelper.WriteLine("Title: {0}", this.title);
     BorrowingUnitTests.TestOutputHelper.WriteLine("Play time: {0}", this.playTime);
     BorrowingUnitTests.TestOutputHelper.WriteLine("Number of copies: {0}", base.NumberOfCopies);
    }
  }
}
