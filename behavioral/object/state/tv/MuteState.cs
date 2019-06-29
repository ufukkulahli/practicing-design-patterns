namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public sealed class MuteState : TvState
  {
    public MuteState(Tv tv) : base(tv) => TvUnitTests.OutputHelper.WriteLine("Tv is muted.");

    protected internal override string Off()
    {
      base.tv.currentState = new OffState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is off.");
      return "Tv is off.";
    }

    protected internal override string On()
    {
      base.tv.currentState = new OnState(base.tv);
      TvUnitTests.OutputHelper.WriteLine("Tv is on.");
      return "Tv is on.";
    }
    protected internal override string Mute()
    {
      TvUnitTests.OutputHelper.WriteLine("Tv is already muted.");
      return "Tv is already muted.";
    }
  }
}