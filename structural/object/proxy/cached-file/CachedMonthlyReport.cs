namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public sealed class CachedMonthlyReport : File
  {
    private FileContent monthlyReportContent;

    public FileContent Content()
    {
      if(this.monthlyReportContent == null)
      {
        this.monthlyReportContent = new MonthlyReport().Content();
      }
      return this.monthlyReportContent;
    }
  }
}
