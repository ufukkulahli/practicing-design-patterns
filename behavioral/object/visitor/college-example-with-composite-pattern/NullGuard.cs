using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public static class NullGuard
  {
    public static T ThrowIfNull<T>(this T obj)
    {
      if (EqualityComparer<T>.Default.Equals(obj, default(T)))
      {
        throw new ArgumentNullException(nameof(obj));
      }

      return obj;
    }
  }
}