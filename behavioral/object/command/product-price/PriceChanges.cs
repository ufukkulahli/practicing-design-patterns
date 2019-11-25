using System.Collections.Generic;
using System.Linq;

namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public sealed class PriceChanges
  {
    private readonly ICollection<Command> changes = new List<Command>();
    private Command priceChangeCommand;

    public decimal Apply(Command priceChangeCommand)
    {
      this.changes.Add(priceChangeCommand);
      this.priceChangeCommand = priceChangeCommand;
      return this.priceChangeCommand.Execute();
    }

    public void UndoLast() => this.priceChangeCommand.Undo();

    public void UndoAll()
    {
      foreach (var change in Enumerable.Reverse(this.changes))
      {
        change.Undo();
      }
    }
  }
}
