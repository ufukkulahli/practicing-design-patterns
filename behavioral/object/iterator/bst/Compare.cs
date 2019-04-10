using System;

namespace practicing_design_patterns.behavioral.@object.iterator.bst
{
  public static class Compare
  {
    public static bool IsGreaterThan<T>(this T value, T other) where T : IComparable<T>
    {
      return value.CompareTo(other) > 0;
    }

    public static bool IsLessThanOrEqualTo<T>(this T value, T other) where T : IComparable<T>
    {
      return value.CompareTo(other) <= 0;
    }
  }
}