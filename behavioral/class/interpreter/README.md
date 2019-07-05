# Interpreter

This pattern specifies how to `evaluate` sentences in a `language` by the help of a `interpreter`.

To build up this pattern, we define a collection of objects(expressions)(syntax tree).  
Each expression implements an `interpret` method which fulfils desired functionality.  
An interpreter traverses `abstract syntax tree` and invokes interpret method on each expression.
