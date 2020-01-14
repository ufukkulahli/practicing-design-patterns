using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public sealed class Game
  {
    private readonly ICollection<Particle> particles = new List<Particle>();

    public Game()
    {
      this.particles.Add(new Particle());
    }

    public void DrawParticles()
    {
      // TODO
    }
  }
}
