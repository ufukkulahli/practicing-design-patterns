namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public sealed class Client
  {
    private readonly File report;
    public Client(File report) => this.report = report;
    public File ObtainReport() => this.report;
  }
}
