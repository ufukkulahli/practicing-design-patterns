namespace practicing_design_patterns.behavioral.@object.customersupport
{
  public class Problem
  {
    public CustomerSupport solvedBy { get; private set; }
    public ProblemSeverity Severity { get; }

    public Problem(ProblemSeverity severity)
    {
      Severity = severity;
    }

    public bool IsSolved => this.solvedBy != null;

    public void SolveBy(CustomerSupport customerSupport)
    {
      this.solvedBy = customerSupport;
    }
  }
}