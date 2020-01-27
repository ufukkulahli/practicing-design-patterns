namespace practicing_design_patterns.creational.@object.prototype.cell
{
  public abstract class Cell
  {
    public bool Alive {get; protected set;} = true;
    public abstract Cell Split();
  }
}