# FactoryMethodExample

**Definition** Factory method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. It lets a class defer instantiation to subclasses

**Applicability**

- A class cannot anticipate the class of objects it must create
- A class wants its subclasses to specify the objects it creates
- Classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate

**Consequences**

- Eliminates the need to bind application-specific classes into your code
- A disadvantage might be that clients need to subclass the factory class just to create a particular type of object.
- Provides hooks for subclasses
- Connects parallel class hierarchies


**Related Patterns**

- [Abstract Factory](https://github.com/andreidana/AbstractFactoryExample)
- [Template Methods](https://github.com/andreidana/TemplateMethodPattern)
- [Prototypes](https://github.com/andreidana/PrototypeExample)