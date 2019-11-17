using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class CommandHistory
  {
    private readonly Stack<Command> history = new Stack<Command>();
    public Command Pop() => this.history.Pop();
    public void Push(Command command) => this.history.Push(command);
  }
}
