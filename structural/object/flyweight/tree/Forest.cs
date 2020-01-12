using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.structural.@object.flyweight.tree
{
  public sealed class Forest
  {
    private readonly ICollection<Tree> trees = new List<Tree>();
 
    public Forest()
    {
      this.trees.Add(new Tree());
      this.trees.Add(new Tree());
      this.trees.Add(new Tree());
    }

    public void GrowTrees(TreeCanvas treeCanvas)
    {
      foreach(var tree in trees)
      {
        tree.Grow(treeCanvas);
      }
    }

    public int TreeCount() => this.trees.Where(tree => tree.Grew).Count();
  }
}
