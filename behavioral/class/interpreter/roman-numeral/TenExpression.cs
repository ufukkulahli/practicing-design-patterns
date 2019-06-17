namespace practicing_design_patterns.behavioral.@class.interpreter.roman_numeral
{
  public class Ten : Expression
  {
    public override string One() => "X";
    public override string Four() => "XL";
    public override string Five() => "L";
    public override string Nine() => "XC";
    public override int Multiplier() => 10;
  }
}