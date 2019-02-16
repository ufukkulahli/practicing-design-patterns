using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  // Employee who has subordinates
  // We use separate "employee" type who does not have subordinates but is a IEmployee
  public class CompositeEmployee : IEmployee
  {
    internal readonly Name name;
    internal readonly Department department;
    internal protected readonly int YearsOfExperience;
    private readonly IList<IEmployee> subordinates;

    public CompositeEmployee(Name name, Department department, int yearsOfExperience)
    {
      this.name = name;
      this.department = department;
      this.YearsOfExperience = yearsOfExperience;
      this.subordinates = new List<IEmployee>();
    }

    public void Add(IEmployee employee) => this.subordinates.Add(employee);
    public void Remove(IEmployee employee) => this.subordinates.Remove(employee);
    public IReadOnlyList<IEmployee> Subordinates => subordinates as IReadOnlyList<IEmployee>;

    public void PrintStructures()
    {
      Console.WriteLine
      ("\t" + this.name + "works in" + this.department + "Experience :" + this.YearsOfExperience + "years");
      foreach (IEmployee employee in this.subordinates)
      {
        employee.PrintStructures();
      }
    }

    public void Accept(IEmployeeVisitor visitor)
    {
      visitor.VisitCompositeElement(this);
    }
  }
}