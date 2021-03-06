namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class Particle
  {
    private readonly RandomPosition randomPosition;
    private readonly ParticleFlyWeight particleFlyweight;
    private string drawInfo;

    public Particle(RandomPosition randomPosition, ParticleFlyWeight particleFlyweight)
    {
      this.randomPosition = randomPosition;
      this.particleFlyweight = particleFlyweight;
    }

    public void DrawSelf()
    {
      this.drawInfo = $"{this.particleFlyweight.ToString()} at {this.randomPosition.ToString()}";
    }

    public string DrawInfo() => this.drawInfo;
  }
}
