namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public sealed class Tv
    {
      public TvState currentState;
      public Tv() => this.currentState = new OffState(this);
      public string PressOffButton() => this.currentState.Off();
      public string PressOnButton() => this.currentState.On();
      public string PressMuteButton() => this.currentState.Mute();
    }
}