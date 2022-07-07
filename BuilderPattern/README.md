## Builder pattern 

The Builder design pattern allows the creation of complex objects without having to worry about implementation issues.

This pattern is used to separate the implementation of a specific case from the logic/client.

A client (physical or software user) needs to build complex objects without knowing its implementation or needs to build complex objects with several implementations.

![](Assets/generic-version.png)
![](Assets/pattern_builder_2.png)
Use the Erector Design Pattern to get rid of a "telescopic builder".

Consider a constructor with ten optional parameters. Making a call to this monstrosity is not very practical: you overload the constructor with several smaller versions, but with fewer parameters. These constructors always reference the main constructor by giving default values to the optional parameters.

from https://refactoring.guru/fr/design-patterns/builder