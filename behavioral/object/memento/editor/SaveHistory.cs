using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.editor
{
  public sealed class SaveHistory
  {
    private readonly Stack<ContentSnapshot> snapshots = new Stack<ContentSnapshot>();
    public void AddNewSnapshot(ContentSnapshot contentSnapshot) => this.snapshots.Push(contentSnapshot);
    public ContentSnapshot GetLastSnapshot() => this.snapshots.Pop();
  }
}
