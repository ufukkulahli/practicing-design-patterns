namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public interface Kitchen
  {
    bool CanPrepare(Reckoning reckoning);
    Orders Prepare(Reckoning reckoning);
  }
}
