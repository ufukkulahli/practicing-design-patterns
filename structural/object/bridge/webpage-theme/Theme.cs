namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public class Theme
  {
    public virtual string Color() => "Light";
    public override string ToString() => this.Color();
  }
}
