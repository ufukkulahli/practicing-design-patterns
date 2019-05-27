namespace practicing_design_patterns.structural.@object.adapter.hunting_game
{
  class WildDogAdapter : ILion
  {
    WildDog wildDog;
    internal WildDogAdapter(WildDog wildDog) => this.wildDog = wildDog;
    public void Roar() => this.wildDog.Bark();
  }
}