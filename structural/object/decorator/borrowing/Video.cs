namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  class Video : LibraryItem
  {
    readonly string director;
    readonly string title;
    readonly int playTime;

    Video(string director, string title, int playTime, int numberOfCopies)
    {
      this.director=director;
      this.title=title;
      this.playTime=playTime;
      base.NumberOfCopies=numberOfCopies;
    }

    public override void Display()
    {
     //TODO:
     //Borrowing.TestOutputHelper.WriteLine("Video:");
     //Borrowing.TestOutputHelper.WriteLine("director: {0}", this.director);
     //Borrowing.TestOutputHelper.WriteLine("Title: {0}", this.title);
     //Borrowing.TestOutputHelper.WriteLine("Play time: {0}", this.playTime);
     //Borrowing.TestOutputHelper.WriteLine("Number of copies: {0}", base.NumberOfCopies);
    }
  }
}
