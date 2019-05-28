namespace practicing_design_patterns.structural.@object.adapter.hunting_game
{
  class WildDogObjectAdapter : ILion
  {
    WildDog wildDog;
    internal WildDogObjectAdapter(WildDog wildDog) => this.wildDog = wildDog;
    public void Roar() => this.wildDog.Bark();
  }
}