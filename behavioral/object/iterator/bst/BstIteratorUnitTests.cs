using Xunit;

namespace practicing_design_patterns.behavioral.@object.iterator.bst
{
  public class BstIteratorUnitTests
  {
    [Fact]
    public void TestThat_BstIterator_ShouldIterateThrough_SmallestToGreatest_Values()
    {
      // ARRANGE
      var treeNode = new TreeNode<int>(5);
      treeNode.Insert(3);
      treeNode.Insert(7);
      treeNode.Insert(1);
      treeNode.Insert(4);
      treeNode.Insert(6);

      var bstIterator = new BstIterator<int>(treeNode);

      // ACT & ASSERT
      Assert.True(bstIterator.MoveNext());
      Assert.Equal(1, bstIterator.Current.value);

      Assert.True(bstIterator.MoveNext());
      Assert.Equal(3, bstIterator.Current.value);

      Assert.True(bstIterator.MoveNext());
      Assert.Equal(4, bstIterator.Current.value);

      Assert.True(bstIterator.MoveNext());
      Assert.Equal(5, bstIterator.Current.value);

      Assert.True(bstIterator.MoveNext());
      Assert.Equal(6, bstIterator.Current.value);

      Assert.True(bstIterator.MoveNext());
      Assert.Equal(7, bstIterator.Current.value);

      Assert.False(bstIterator.MoveNext());
    }
  }
}