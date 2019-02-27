using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.customersupport
{
  class FrontDesk : CustomerSupport
  {
    protected override IEnumerable<ProblemSeverity> Responsibilities
    {
      get
      {
        yield return ProblemSeverity.NoProblem;
        yield return ProblemSeverity.Simple;
      }
    }
  }
}