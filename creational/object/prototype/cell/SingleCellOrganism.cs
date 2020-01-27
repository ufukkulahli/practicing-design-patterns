namespace practicing_design_patterns.creational.@object.prototype.cell
{
  public sealed class SingleCellOrganism : Cell
  {
    public SingleCellOrganism() { }
    public SingleCellOrganism(SingleCellOrganism dividend) => base.Alive = dividend.Alive;
    public override Cell Split()  => new SingleCellOrganism(this);
  }
}