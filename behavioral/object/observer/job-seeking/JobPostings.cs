using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.observer.job_seeking
{
  public sealed class JobPostings
  {
    private readonly List<JobSeeker> jobSeekers = new List<JobSeeker>();

    public void Subscribe(params JobSeeker[] jobSeekers)
    {
      foreach(var jobSeeker in jobSeekers)
      {
        this.jobSeekers.Add(jobSeeker);
      }
    }

    public void AddJob(JobPost jobPost) => this.NotifySeekers(jobPost);

    private void NotifySeekers(JobPost jobPost)
    {
      foreach(var seeker in this.jobSeekers)
      {
        seeker.GetInformedAbout(jobPost);
      }
    }
  }
}
