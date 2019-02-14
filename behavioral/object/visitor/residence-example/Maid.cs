namespace practicing_design_patterns.behavioral.@object.visitor
{
  internal class Maid : IResidenceVisitor
  {
    public void Visit(Bathroom room)
    {
      room.Clean();
    }

    public void Visit(Bedroom room)
    {
      room.Clean();
    }

    public void Visit(Kitchen room)
    {
      room.Clean();
    }

    public void Visit(LivingRoom room)
    {
      room.Clean();
    }
  }
}