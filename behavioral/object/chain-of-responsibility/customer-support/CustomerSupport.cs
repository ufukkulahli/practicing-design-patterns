using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.behavioral.@object.customersupport
{
  public abstract class CustomerSupport
  {
    private CustomerSupport escalatedSupport;

    public void SetEscalation(CustomerSupport customerSupport)
    {
      this.escalatedSupport = customerSupport;
    }

    public void SolveProblem(Problem problem)
    {
      if (this.CanSolveProblem(problem))
      {
        problem.SolveBy(this);
        CustomerSupportUnitTests.TestOutputHelper.WriteLine
          ("Problem with {0} severity is solved by {1}.", problem.Severity, problem.solvedBy);
        return;
      }

      this.escalatedSupport.SolveProblem(problem);
    }

    protected abstract IEnumerable<ProblemSeverity> Responsibilities { get; }

    private bool CanSolveProblem(Problem problem)
    {
      return this.Responsibilities?.Any(severity => severity == problem.Severity) ?? false;
    }
  }
}