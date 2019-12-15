namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public interface Shape
  {
    void Draw();
    IState State();
    void Move(Coordinate coordinate);
  }
}
