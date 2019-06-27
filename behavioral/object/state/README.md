# State

Allows an object to `alter` its `behaviour` at runtime `when` its internal `state changes` (actually, appears to change).  
Pattern close to the concept of `finite-state machines`.  
Can be interpreted as a `strategy pattern`. The difference between them, `states` may know each other while `strategies` do not.

## Implementation

* There is the main object (which needs to have a state or let's say stateful)
* There is the base class for states
* There are concrete state classes that implement base state
* These concrete states define different statuses
* The need of the state change rises, the main object points to a different state object
* Making point the main object to another state is the design of state change handling mechanism.
* State change a.k.a. `transition`  the context into another state could be handled by `main object`, in `states` or by `table-driven approach`.
