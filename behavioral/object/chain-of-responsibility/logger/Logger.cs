namespace practicing_design_patterns.behavioral.@object.logger
{
  public abstract class Logger
  {
    protected internal readonly LogLevel LogMask;
    protected Logger Next;

    protected Logger(LogLevel logMask)
    {
      this.LogMask = logMask;
    }

    public Logger SetNext(Logger next)
    {
      this.Next = next;
      return next;
    }

    public void Message(string message, LogLevel severity)
    {
      if ((severity & this.LogMask) != 0)
      {
        WriteMessage(message);
      }

      Next?.Message(message, severity);
    }

    protected abstract void WriteMessage(string message);
  }
}