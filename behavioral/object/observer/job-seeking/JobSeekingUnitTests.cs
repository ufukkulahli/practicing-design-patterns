using Xunit;

namespace practicing_design_patterns.behavioral.@object.observer.job_seeking
{
  public class JobSeekingUnitTests
  {
    [Fact]
    public void JoeAndJackDaltonGetEmployed()
    {
      // Arrange
      var joeDalton = new JobSeeker("Joe Dalton");
      var jackDalton = new JobSeeker("Jack Dalton");

      var jobPostings = new JobPostings();
      jobPostings.Subscribe(joeDalton, jackDalton);

      // Act
      jobPostings.AddJob(new JobPost("Bank Robbery"));

      // Assert
      Assert.True(joeDalton.IsEmployed());
      Assert.True(jackDalton.IsEmployed());
    }

    [Fact]
    public void JackDaltonNotInterestedInGettingJob()
    {
      // Arrange
      var joeDalton = new JobSeeker("Joe Dalton");
      var jackDalton = new JobSeeker("Jack Dalton");

      var jobPostings = new JobPostings();
      jobPostings.Subscribe(joeDalton, jackDalton);

      // (Jack is not intereseted in job)
      jobPostings.Unsubscribe(jackDalton);

      // Act
      jobPostings.AddJob(new JobPost("Bank Robbery"));

      // Assert
      Assert.True(joeDalton.IsEmployed());
      Assert.False(jackDalton.IsEmployed());
    }
  }
}
