namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public interface IIterator<out T>
  {
    bool HasNext();
    T Next();
  }
}
