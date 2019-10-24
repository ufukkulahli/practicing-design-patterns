using System;
using practicing_design_patterns.behavioral.@object.strategy.billing;

namespace practicing_design_patterns
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
  public sealed class Bank
  {
    public bool HasNotSufficientSavings(Customer customer, Dollar dollar) => true;
  }
  public sealed class Loan
  {
    public bool HasNoBadLoans(Customer customer) => true;
  }
  public sealed class Credit
  {
    public bool HasGoodCredit(Customer customer) => true;
  }

}
