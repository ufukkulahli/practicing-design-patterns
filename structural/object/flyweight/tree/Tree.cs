namespace practicing_design_patterns.structural.@object.flyweight.tree
{
  public sealed class Tree
  {
    private TreeCanvas canvas;
    public bool Grew {get; private set;}

    public void Grow(TreeCanvas treeCanvas)
    {
      this.Grew = true;
      // Use given canvas for this tree.
      this.canvas = treeCanvas;
    }
  }
}
