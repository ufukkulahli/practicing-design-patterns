namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public sealed class FileContent
  {
    public string Value() => "Current month's report as follows...";
    public override string ToString() => this.Value();
  }
}
