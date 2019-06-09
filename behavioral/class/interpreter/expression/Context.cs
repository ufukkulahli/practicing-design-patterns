using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public class Context
  {
    private readonly IDictionary<string, Expression> variables;

    public Context(params KeyValuePair<string, Expression>[] variables)
    {
      this.variables = new Dictionary<string, Expression>(variables);
    }
  }
}