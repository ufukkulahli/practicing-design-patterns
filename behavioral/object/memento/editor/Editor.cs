using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.editor
{
  public sealed class Editor
  {
    private string content = string.Empty;
    private ContentSnapshot contentSnapshot;

    public void Content(string text) => this.content += text;
    public void Save() => this.contentSnapshot = new ContentSnapshot(this.content);
    public void RestoreContent() => this.content = this.contentSnapshot.Value();
    public string Content() => this.content;
  }
}
