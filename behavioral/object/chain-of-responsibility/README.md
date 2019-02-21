**Chain of Responsibility**

This pattern consists of several processing objects (or handlers)
and a source object (or input/request/command) to be processed on.
When we put these handlers side by side they form the "chain".
Through this chain, given request object is processed by each handler respectively
and passed to the next handler in the chain.
Request object goes through the first handler in the chain
and may or may not reach to the last handler.
Execution life of it is decided by handlers.
Handlers have relative responsibilities against request object.