namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public sealed class OnState : TvState
  {
    public OnState(Tv tv) : base(tv) => TvUnitTests.OutputHelper.WriteLine("Tv is on.");

    protected internal override string Off()
    {
      base.tv.currentState = new OffState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is off.");
      return "Tv is off.";
    }

    protected internal override string On()
    {
      TvUnitTests.OutputHelper.WriteLine("Tv is already on.");
      return "Tv is already on.";
    }
    protected internal override string Mute()
    {
      base.tv.currentState = new MuteState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is muted.");
      return "Tv is muted.";
    }
  }
}