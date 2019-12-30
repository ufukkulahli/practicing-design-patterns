namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public abstract class WebPage
  {
    protected readonly Theme defaultTheme = new Theme();
    public WebPage(Theme theme) => this.defaultTheme = theme;
    public virtual string Content() => string.Empty;
  }
}
