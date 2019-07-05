# Iterator design pattern

Although this pattern consists of several objects gets its name from an object called `Iterator`.  

Iterator object plays the bigger role in this pattern.  
So what does it do?  

Let's say we have a collection of person objects.  
We want to print the name of people one by one.  
That means, we `iterate` through each person (item) in collection and access item's name field then print it.  
To us be able to do that iteration, there would be an object handles all accessing items sequentially.  

In this explanation our `iterator` object goes over all items one by one till left any to iterate.  
What if there is a need for different kind of iteration?  
Such as going through only even numbers in a collection.  
For this and many more custom/complex iterations  
we create new Iterators and implement desired iteration algorithm under the hood.

So, more Wikipedia like definition would be:
Iterator pattern allows separation of desired custom/complex traversing algorithm from collections.  
Traverse of a collection without exposing its underlying data structure (list, stack...).

There could be different kind of data structures held in collections and iterators.  
But client code just uses given interfaces and loops over each item without knowing underlying mechanisms.  
So we can implement any other iterators and aggregates (collections) without effecting the client code.
