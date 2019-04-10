using System;

namespace practicing_design_patterns.behavioral.@object.iterator.bst
{
  public class TreeNode<T> where T : IComparable<T>
  {
    private T value;
    private TreeNode<T> Left;
    private TreeNode<T> Right;

    public TreeNode(T value)
    {
      this.value = value;
    }

    public void Insert(T valueToInsert)
    {
      var parent = GetParentNodeOfValueToBeInserted(valueToInsert);
      parent.InsertNewChild(valueToInsert);
    }

    private TreeNode<T> GetParentNodeOfValueToBeInserted(T valueToInsert)
    {
      TreeNode<T> parent = null;
      var current = this;

      while (current != null)
      {
        parent = current;
        current = current.TraverseOneLevelDown(valueToInsert);
      }

      return parent;
    }

    private TreeNode<T> TraverseOneLevelDown(T valueToInsert)
    {
      if (this.value.IsGreaterThan(valueToInsert))
      {
        return this.Left;
      }

      return this.Right;
    }

    private void InsertNewChild(T valueToInsert)
    {
      if (this.value.IsLessThanOrEqualTo(valueToInsert))
      {
        this.Right = new TreeNode<T>(valueToInsert);
        return;
      }

      this.Left = new TreeNode<T>(valueToInsert);
    }
  }
}