using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.customersupport
{
  class Engineer : CustomerSupport
  {
    protected override IEnumerable<ProblemSeverity> Responsibilities
    {
      get { yield return ProblemSeverity.Critical; }
    }
  }
}