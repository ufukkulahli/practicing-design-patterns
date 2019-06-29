namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public abstract class TvState
    {
      protected Tv tv;
      protected TvState(Tv tv) => this.tv = tv;
      protected internal abstract string Off();
      protected internal abstract string On();
      protected internal abstract string Mute();
    }
}