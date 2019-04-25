using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  public class BorrowingUnitTests
  {
    public static ITestOutputHelper TestOutputHelper;

    public BorrowingUnitTests(ITestOutputHelper testOutputHelper)
    {
      TestOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Should_AssertRemainingBookCopiesAs1_When_Borrowed()
    {
      // ARRANGE
      var book = new Book
      (
        "Alexandre Dumas",
        "The Count of Monte Cristo",
        3
      );

      var video = new Video
      (
        "Kevin Reynolds",
        "The Count of Monte Cristo",
        300,
        8
      );

      var borrowableBook = new Borrowable(book);

      // ACT
      book.Display();
      video.Display();
      borrowableBook.BorrowItem("Joe the customer");
      borrowableBook.BorrowItem("Jack the customer");
      borrowableBook.Display();

      // ASSERT
      Assert.Equal(1, book.NumberOfCopies);
    }
    
    [Fact]
    public void Should_AssertRemainingVideoCopiesAs8_When_Borrowed()
    {
      // ARRANGE
      var video = new Video
      (
        "Kevin Reynolds",
        "The Count of Monte Cristo",
        300,
        8
      );

      var borrowableVideo = new Borrowable(video);

      // ACT
      video.Display();
      borrowableVideo.BorrowItem("Joe the customer");
      borrowableVideo.Display();
      borrowableVideo.ReturnItem("Joe the customer");

      // ASSERT
      Assert.Equal(8, video.NumberOfCopies);
    }
  }
}