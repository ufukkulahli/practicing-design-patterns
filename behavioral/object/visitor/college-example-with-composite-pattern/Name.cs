using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Name
  {
    private readonly string value;
    public Name(string value) =>
      this.value = value ?? throw new ArgumentNullException(nameof(value));
    public string GetName() => this.value;
    public override string ToString() => this.value;
  }
}