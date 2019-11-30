namespace practicing_design_patterns.behavioral.@object.observer.job_seeking
{
  public sealed class JobSeeker
  {
    private string fullName;
    private string currentJob;
    public JobSeeker(string fullName) => this.fullName = fullName;
    public void GetInformedAbout(JobPost jobPost) => this.currentJob = jobPost.ToString();
    public bool IsEmployed() => !string.IsNullOrEmpty(this.currentJob);
  }
}
