using System;
using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.structural.@object.proxy.authentication
{
  public sealed class ProxyWeeklySalesReport : Report
  {
    private readonly Report report = new WeeklySalesReport();
    private readonly string User;
    private readonly IEnumerable<string> allowedUsers = new List<string>(){"Joe William, Jack William"};
    private ProxyWeeklySalesReport(string user) => this.User = user;
    public static ProxyWeeklySalesReport ForUser(string user) => new ProxyWeeklySalesReport(user);

    public string Content()
    {
      if(this.allowedUsers.Contains(this.User))
      {
        return this.report.Content();
      }
      return string.Empty;
    }
  }
}
