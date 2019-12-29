namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public abstract class WebPage
  {
    protected readonly Theme defaultTheme = new Theme();
    public virtual string Content() => string.Empty;
  }
}
