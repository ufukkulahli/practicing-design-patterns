using System;

namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  internal class HappyHour : Billing
  {
    public decimal Apply(decimal price) => Convert.ToDecimal(Convert.ToDouble(price) * 0.5);
  }
}
