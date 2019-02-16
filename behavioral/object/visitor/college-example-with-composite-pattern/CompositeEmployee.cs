// Employee who has subordinates
// We use separate "employee" type who does not have subordinates but is a IEmployee

using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class CompositeEmployee : IEmployee
  {
    internal readonly Name Name;
    internal readonly Department Department;
    internal readonly YearsOfExperience YearsOfExperience;
    private readonly IList<IEmployee> subordinates;

    public CompositeEmployee(Name name, Department department, YearsOfExperience yearsOfExperience)
    {
      this.Name = name;
      this.Department = department;
      this.YearsOfExperience = yearsOfExperience;
      this.subordinates = new List<IEmployee>();
    }

    public void Add(IEmployee employee) => this.subordinates.Add(employee);
    public void Remove(IEmployee employee) => this.subordinates.Remove(employee);
    public IReadOnlyList<IEmployee> Subordinates => subordinates as IReadOnlyList<IEmployee>;

    public void PrintStructures()
    {
      PrintDetail();
      foreach (var employee in this.subordinates)
      {
        employee.PrintStructures();
      }
    }

    private void PrintDetail()
    {
      Console.WriteLine
      ("\t" + this.Name + "works in" + this.Department + "Experience :" + this.YearsOfExperience + "years");
    }

    public void Accept(IEmployeeVisitor visitor)
    {
      visitor.VisitCompositeElement(this);
    }
  }
}