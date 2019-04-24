namespace practicing_design_patterns.structural.@object.decorator.borrowing
{
  abstract class Decorator : LibraryItem
  {
    protected LibraryItem libraryItem;
    public Decorator(LibraryItem libraryItem)=>this.libraryItem=libraryItem;
    public override void Display()=>this.libraryItem.Display();
  }
}
