using System;
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

    internal Expression GetVariable(string name)
    {
      return this.variables[name];
    }

    internal void SetVariable(string name, Expression expression)
    {
      this.variables[name] = expression;
    }
  }
}