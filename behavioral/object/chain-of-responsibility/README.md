# Chain of Responsibility

This pattern consists of several processing objects (or handlers) and a source object (or input/request/command) to be processed on.  
When we put these handlers side by side they form the "chain".  
Through this chain, given request object is processed by each handler respectively and passed to the next handler in the chain.  
Request object goes through the first handler in the chain and may or may not reach to the last handler.  
Execution life of it is decided by handlers.  
Handlers have relative responsibilities against request object.  

Chain of Responsibility pattern's relations with other patterns:  
This pattern, Command, Mediator, Observer concerns with connecting senders and receivers requests.  
Composite pattern can be used in conjunction with this pattern. A request may be passed from parent components down to the root of the object tree.  
In this pattern, we can implement handlers as Commands. We can execute different operations over the same context object, represented by a request.  
Another approach, request itself is a Command object. We can execute the same operation in a series of different contexts linked into a chain.  
Decorator pattern has very similar class structures with this pattern. These two patterns rely on recursive composition to pass the execution through a series objects. This pattern's handlers can execute different operations. They can break the chain. Decorators can not break the flow of execution. Decorators can extend the objects behaviour while keeping it consistent with the base interface.
