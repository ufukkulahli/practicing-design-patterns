namespace practicing_design_patterns.behavioral.@class.interpreter.roman_numeral
{
  public class ThousandExpression : Expression
  {
    public override string One() => "M";
    public override string Four() => " ";
    public override string Five() => " ";
    public override string Nine() => " ";
    public override int Multiplier() => 1000;
  }
}