namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class Particle
  {
    private readonly RandomPosition randomPosition;
    private readonly ParticleFlyWeight particleFlyweight;

    public Particle(RandomPosition randomPosition, ParticleFlyWeight particleFlyweight)
    {
      this.randomPosition = randomPosition;
      this.particleFlyweight = particleFlyweight;
    }
  }
}
