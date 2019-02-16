using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Department
  {
    private string value;
    public Department(string value) =>
      this.value = value ?? throw new ArgumentNullException(nameof(value));
    public string GetDepartment() => this.value;
    public override string ToString() => this.value;
  }
}