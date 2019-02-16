using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public interface IEmployeeVisitor
  {
    void VisitCompositeElement(CompositeEmployee employee);
    void VisitLeafNode(Employee employee);
  }
}