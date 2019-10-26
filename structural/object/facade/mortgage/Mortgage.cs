using practicing_design_patterns.behavioral.@object.strategy.billing;

namespace practicing_design_patterns.structural.@object.facade.mortgage
{
  public sealed class Mortgage
  {
    private readonly Bank bank = new Bank();
    private readonly Loan loan = new Loan();
    private readonly Credit credit = new Credit();

    public bool IsEligibleFor(Customer john, Dollar dollar)
    {
      return
        this.bank.HasNotSufficientSavings(john, dollar) &&
        this.loan.HasNoBadLoans(john) &&
        this.credit.HasGoodCredit(john);
    }
  }
}
