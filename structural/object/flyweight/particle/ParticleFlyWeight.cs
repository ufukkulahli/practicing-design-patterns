namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class ParticleFlyWeight
  {
    private string color;
    private string spriteFile;

    public ParticleFlyWeight(string color, string spriteFile)
    {
      this.color = color;
      this.spriteFile = spriteFile;
    }
  }
}
