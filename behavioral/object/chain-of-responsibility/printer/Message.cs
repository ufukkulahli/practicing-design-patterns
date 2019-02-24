namespace practicing_design_patterns.behavioral.@object.printer
{
  public class Message
  {
    public Priority Priority { get; }
    public string Text { get; }

    public Message(Priority priority, string text)
    {
      Priority = priority;
      Text = text;
    }
  }
}