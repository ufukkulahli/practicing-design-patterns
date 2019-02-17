using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class EmployeeVisitor : IEmployeeVisitor
  {
    public void VisitCompositeElement(CompositeEmployee employee)
    {
      PrintPromotionStatus
        (employee, employee.YearsOfExperience.IsEligibleForPromotionOver15Years());
    }

    private void PrintPromotionStatus(CompositeEmployee employee, bool eligibleForPromotion)
    {
      Console.WriteLine
        ($"\t\t{employee.Name}from{employee.Department}is eligible for promotion?{eligibleForPromotion}");
    }

    public void VisitLeafNode(Employee employee)
    {
      PrintPromotionStatus
        (employee, employee.YearsOfExperience.IsEligibleForPromotionOver12Years());
    }

    private void PrintPromotionStatus(Employee employee, bool eligibleForPromotion)
    {
      Console.WriteLine
        ($"\t\t{employee.Name}from{employee.Department}is eligible for promotion?{eligibleForPromotion}");
    }
  }
}