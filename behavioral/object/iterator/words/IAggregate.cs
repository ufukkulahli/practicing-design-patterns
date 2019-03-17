namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public interface IAggregate<out T>
  {
    Iterator<T> CreateIterator();
  }
}
