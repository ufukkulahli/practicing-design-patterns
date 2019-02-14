namespace practicing_design_patterns.behavioral.@object.visitor
{
  internal class Plumber : IResidenceVisitor
  {
    public void Visit(Bathroom room)
    {
      room.Repair();
    }

    public void Visit(Bedroom room)
    {
      return;
    }

    public void Visit(Kitchen room)
    {
      room.Repair();
    }

    public void Visit(LivingRoom room)
    {
      return;
    }
  }
}