**Binary Search Tee**

This data structure consist of:
* Root node
* Left node (this node also a root by itself and contains same elements)
* Right node (this node also a root by itself and contains same elements)
* Value of node

![Alt text](IMG_0956.jpg?raw=true)

**Binary Search Tree Iterator**

A `Binary Search Tree` `Iterator` pattern implementation.  
The Iterator will `traverse` the tree by `binary tree traversal`method and return the values `in order`.  
With the tree above, BTS Iterator would return values in order like: 1, 3, 4, 6, 7, 8, 10, 13, 14.

To make process efficient:
* First, design the tree upfront. Meaning that, 
  insert the values into left if small or right if bigger than the current node's value.
* Second, design the BST Iterator's path stack.
  Instead of traversing the whole tree we will just keep the paths of nodes in a path stack with the smallest node in mind.
  Go to next smallest node and insert it to path stack.
* Design a `next()` method to `pop` values from path stack and provide next smallest node. 