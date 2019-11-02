namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public sealed class CachedMonthlyReport : File
  {
    private File actualFile;

    public FileContent Content()
    {
      if(this.actualFile == null)
      {
        this.actualFile = new MonthlyReport();
      }
      return this.actualFile.Content();
    }
  }
}
