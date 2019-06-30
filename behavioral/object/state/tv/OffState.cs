namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public sealed class OffState : TvState
  {
    public OffState(Tv tv) : base(tv) => TvUnitTests.OutputHelper.WriteLine("Tv is off.");

    protected internal override string Off()
    {
      TvUnitTests.OutputHelper.WriteLine("Tv is already off.");
      return "Tv is already off.";
    }

    protected internal override string On()
    {
      base.tv.currentState = new OnState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is on.");
      return "Tv is on.";
    }
    protected internal override string Mute()
    {
      base.tv.currentState = new MuteState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is muted.");
      return "Tv is muted.";
    }
  }
}