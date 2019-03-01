**Template method pattern**

Defines the skeleton of an algorithm, defers some steps to subclasses.

We arrange functionalities in a class (like a template. some sources say to them placeholder or "hook" methods).  
Then we allow some functionalities in this base class to be overridden in sub classes (rest is filled in sub class).  

The pattern is an example of "inversion of control".  
Because high-level code no longer determines what algorithms to run;  
a lower-level algorithm is selected at run-time.  
Sub class is created at compile-time.  
This inverted control structure has been labelled "the Hollywood principle" - "don't call us, we'll call you".  

The key thing here is;  
 we instantiate the sub class,  
 then we invoke the "template method" with sub class,  
 but the method we invoke, actually lives in base class.  
 so within that method, other class method calls happen,  
 since "abstract methods" are simply empty(due to their abstractness)  
 their "overridden" counterparts will be called from "relevant" sub class(the instantiated one).  
 
Template method pattern's relations with other patterns:  
Factory method is a specialization of this pattern.  
Template method is based on inheritence. Subclasses alters parts of algorithm.  
Strategy pattern is based on composition, we can alter the behaviour by supplying different implementations.  
Template method works at the class level, it is static.  
Strategy pattern works at the object level, lets us switch behaviour at runtime.
