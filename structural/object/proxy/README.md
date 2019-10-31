# Proxy pattern

A proxy object acts as a 'real' one so that the client thinks that it is using the actual service of the real object.  
Simply put, we substitute the real one with the proxy (or fake) one.  
The reason why the client not know about this change is that both real and proxy objects implement same contract (interface).
