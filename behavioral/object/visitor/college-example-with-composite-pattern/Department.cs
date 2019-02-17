using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Department
  {
    private readonly string value;
    public Department(string value) =>
      this.value = value.ThrowIfNull();
    public string GetDepartment() => this.value;
    public override string ToString() => this.value;
  }
}