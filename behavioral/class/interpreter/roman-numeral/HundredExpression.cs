namespace practicing_design_patterns.behavioral.@class.interpreter.roman_numeral
{
  public class Hundred : Expression
  {
    public override string One() => "C";
    public override string Four() => "CD";
    public override string Five() => "D";
    public override string Nine() => "CM";
    public override int Multiplier() => 100;
  }
}