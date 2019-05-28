using practicing_design_patterns.structural.@object.adapter.hunting_game;

namespace practicing_design_patterns.structural.@class.adapter.hunting_game
{
  class WildDogClassAdapter : WildDog, ILion
  {
    public void Roar()
    {
      base.Bark();
    }
  }
}