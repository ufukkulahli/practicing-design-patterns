**Adapter**

Adapter pattern allows clients to work seamlessly with substantially different objects.  
Our client works and expects specific kind of objects marked by an interface.  
Objects with different interfaces, the client could not work with them, as it should be.  
Here comes the power of the Adapter pattern.  

*Class Adapter*
Create an adapter class for that distinct object.  
Instead of accepting the object through the constructor, `extend` it.  
Then make the adapter class implement the client's interface.  
Within the implemented behaviour of interface call the base class' behaviour.