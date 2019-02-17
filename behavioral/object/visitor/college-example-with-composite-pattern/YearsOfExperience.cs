using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class YearsOfExperience
  {
    private readonly int value;

    public YearsOfExperience(int value)
    {
      if (value <= 0 || value >= 100)
      {
        throw new ArgumentOutOfRangeException(nameof(value));
      }
      this.value = value;
    }

    public int GetValue() => this.value;
    public override string ToString() => Convert.ToString(this.value);
    //We'll promote them if experience is greater than 15 years
    public bool IsEligibleForPromotionOver15Years() => this.value > 15;
    //We'll promote them if experience is greater than 12 years
    public bool IsEligibleForPromotionOver12Years() => this.value > 12;
  }
}