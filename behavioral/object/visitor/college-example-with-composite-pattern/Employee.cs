using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Employee : IEmployee
  {
    internal readonly Name name;
    internal readonly Department department;
    internal readonly int yearsOfExperience;

    public Employee(Name name, Department department, int yearsOfExperience)
    {
      this.name = name;
      this.department = department;
      this.yearsOfExperience = yearsOfExperience;
    }

    public void PrintStructures()
    {
      Console.WriteLine
        ("\t\t" + this.name + "works in" + this.department + "Experience :" + this.yearsOfExperience + "years");
    }

    public void Accept(IEmployeeVisitor visitor)
    {
      visitor.VisitLeafNode(this);
    }
  }
}