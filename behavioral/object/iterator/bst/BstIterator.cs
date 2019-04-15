using System;
using System.Collections;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.iterator.bst
{
  public class BstIterator<T> : IEnumerator<TreeNode<T>> where T : IComparable<T>
  {
    private readonly LinkedList<TreeNode<T>> pathStack;
    
    public BstIterator(TreeNode<T> root)
    {
      this.pathStack = new LinkedList<TreeNode<T>>();
      PushPathToNextSmallest(root);
    }

    private void PushPathToNextSmallest(TreeNode<T> root)
    {
      while (root!=null)
      {
        this.pathStack.AddFirst(root);
        root = root.Left;
      }
    }

    private TreeNode<T> Next()
    {
      var first = this.pathStack.First.Value;
      this.PushPathToNextSmallest(first);
      return first;
    }
    
    public bool MoveNext()
    {
      if (this.pathStack.Count > 0)
      {
        this.Current = this.Next();
        return true;
      }
      return false;
    }

    public TreeNode<T> Current { get; private set; }

    object IEnumerator.Current => Current;

    public void Reset()
    {
      throw new NotImplementedException();
    }
    
    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}