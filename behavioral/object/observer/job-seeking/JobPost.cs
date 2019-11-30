namespace practicing_design_patterns.behavioral.@object.observer.job_seeking
{
  public sealed class JobPost
  {
    private string name;
    public JobPost(string name) => this.name = name;
    public override string ToString() => this.name;
  }
}
