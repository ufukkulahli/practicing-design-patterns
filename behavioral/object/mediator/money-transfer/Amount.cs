using System;
using System.Globalization;

namespace practicing_design_patterns.behavioral.@object.mediator.moneytransfer
{
  public class Amount
  {
    internal readonly decimal value;
    internal readonly Currency currency;

    public Amount(decimal value, Currency currency)
    {
      this.value = value;
      this.currency = currency;
    }

    public override string ToString()
    {
      return $"{this.currency}{Convert.ToString(this.value, CultureInfo.InvariantCulture)}";
    }
  }
}