using System;

namespace practicing_design_patterns.structural.@object.flyweight.tree
{
  public sealed class Tree
  {
    public bool Grew {get; private set;}

    public void Grow(TreeCanvas treeCanvas)
    {
      this.Grew = true;
    }
  }
}
