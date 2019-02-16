using static System.Console;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class EmployeeVisitor : IEmployeeVisitor
  {
    public void VisitCompositeElement(CompositeEmployee employee)
    {
      PrintPromotionStatus
        (employee, employee.YearsOfExperience.IsEligibleForPromotionOver15Years());
    }

    //We'll promote them if experience is greater than 15 years
    private void PrintPromotionStatus(CompositeEmployee employee, bool eligibleForPromotion)
    {
      WriteLine
        ($"\t\t{employee.Name}from{employee.Department}is eligible for promotion?{eligibleForPromotion}");
    }

    public void VisitLeafNode(Employee employee)
    {
      PrintPromotionStatus
        (employee, employee.YearsOfExperience.IsEligibleForPromotionOver12Years());
    }

    //We'll promote them if experience is greater than 12 years
    private void PrintPromotionStatus(Employee employee, bool eligibleForPromotion)
    {
      WriteLine
        ($"\t\t{employee.Name}from{employee.Department}is eligible for promotion?{eligibleForPromotion}");
    }
  }
}