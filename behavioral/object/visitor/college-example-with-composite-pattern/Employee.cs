using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Employee : IEmployee
  {
    internal readonly Name Name;
    internal readonly Department Department;
    internal readonly YearsOfExperience YearsOfExperience;

    public Employee
    (
      Name name,
      Department department,
      YearsOfExperience yearsOfExperience
    )
    {
      this.Name = name.ThrowIfNull();
      this.Department = department.ThrowIfNull();
      this.YearsOfExperience = yearsOfExperience.ThrowIfNull();
    }

    public void PrintStructures()
    {
      Console.WriteLine
        ("\t\t" + this.Name + "works in" + this.Department + "Experience :" + this.YearsOfExperience + "years");
    }

    public void Accept(IEmployeeVisitor visitor)
    {
      visitor.VisitLeafNode(this);
    }
  }
}