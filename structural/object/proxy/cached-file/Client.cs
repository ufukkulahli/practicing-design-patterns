namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  internal class Client
  {
    private readonly File report;
    public Client(File report) => this.report = report;
    internal File ObtainReport() => this.report;
  }
}
