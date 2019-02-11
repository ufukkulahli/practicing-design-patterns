Template method pattern

Defines the skeleton of an algorithm, defers some steps to subclasses.

We arrange functionalities in a class (like a template).
Then we allow some functionalities in this base class to be overridden in sub classes (rest is filled in sub class).

The pattern is an example of "inversion of control".
Because high-level code no longer determines what algorithms to run;
a lower-level algorithm is selected at run-time.

Sub class is created at compile-time.