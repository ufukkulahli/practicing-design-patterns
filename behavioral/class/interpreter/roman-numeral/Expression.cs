namespace practicing_design_patterns.behavioral.@class.interpreter.roman_numeral
{
  public abstract class Expression
  {
    public abstract string One();
    public abstract string Four();
    public abstract string Five();
    public abstract string Nine();
    public abstract int Multiplier();

    public void Interpret(Context context)
    {
    // TODO
    }
  }
}