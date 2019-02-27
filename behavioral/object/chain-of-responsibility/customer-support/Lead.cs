using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.customersupport
{
  class Lead : CustomerSupport
  {
    protected override IEnumerable<ProblemSeverity> Responsibilities
    {
      get { yield return ProblemSeverity.Troublesome; }
    }
  }
}