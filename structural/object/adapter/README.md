**Adapter**

Adapter pattern allows clients to work seamlessly with substantially different objects.  
Our client works and expects specific kind of objects marked by an interface.  
Objects with different interfaces, the client could not work with them, as it should be.  
Here comes the power of the Adapter pattern.  

*Object Adapter*
Create an `adapter` (wrapper) for that distinct object.  
Provide the object to its adapter through the constructor.  
Make it implement the interface of the client expected.  
Under the hood, within the implemented behaviour, call the distinct object's behaviour.  
Then simply, give the adapter object to the client and let it perform its work as nothing happened.