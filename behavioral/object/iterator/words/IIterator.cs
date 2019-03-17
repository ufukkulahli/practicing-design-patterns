namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public interface Iterator<out T>
  {
    bool HasNext();
    T Next();
  }
}
