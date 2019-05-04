**Decorator Pattern**

This pattern allows us to `add responsibilities` to `objects` `dynamically`.  
Decorators provide `flexible alternative` to `subclassing` for `extending functionality`.  
Add `behaviour`, `state` to objects at `run-time`.

Helps
* Open-Closed principle (Class should be closed for modification but open for extension)
* Object composition over inheritance
* Single Responsibility Principle (Pattern allows functionality to be divided between classes with unique areas of concern)

Similar to
* Chain of Responsibility Pattern (Exactly one of the classes handles the request. In decorator, all classes handle the request)

We may hear that `Wrapper` could be used instead of `Decorator` word for this pattern, which is also right.  

But what builds this pattern? What are the key things?  
First and the obvious one is accepting objects in constructor that has same `contract (interface/base-class)`.  
Despite of all concrete `decorator` and `component` classes have same contract (BaseComponent), these two are separated by explicitly implementing `BaseDecorator` / `BaseComponent` contracts.  
Whe may say, the latter becomes `signature` of this pattern since we appeal to `composition`.
