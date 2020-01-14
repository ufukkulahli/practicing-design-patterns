using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class Game
  {
    private readonly ICollection<Particle> particles = new List<Particle>();

    public Game()
    {
      var particleFlyweight = new ParticleFlyWeight("silver", "particle_sprite.png");
      this.particles.Add(new Particle(new RandomPosition(), particleFlyweight));
    }

    public void DrawParticles()
    {
    }
  }
}
