**Visitor pattern**

This pattern allows us to "define a new operation"
without changing the classes of the elements on which it operates.

To describe this pattern more humanly, let's say;
We (_visitor_) want to visit some places.
And we describe (within us, technically in our class) the places to be visited.
Naturally, there will be places (_visitee_) to be visited, such as museum.
Museum describes a visitor _acceptance method_.
With the two entities at hand, the place to be _visited_ which is museum _accepts_ us which is _visitor_.
This approach gives us to add new types.
Such as we may add new _visitor_ type; _tourist_, new _visitee_ type _theater_.

This model, allows extension, disallows modification.
That means support of the _open-close principle_.
Also the pattern has a drawback. The encapsulation is not _key_ concern of it.
With many visitors we can destroy the encapsulation.

When combined with _Composite and Iterator_ pattern, visitor pattern becomes much more powerful.