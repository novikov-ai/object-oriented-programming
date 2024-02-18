# Basics paradigms

### Inheritance
[Dog is derived class from Animal](Basics.cs#L28)

### Polymorphism
[Dog overrides method Run provided from Animal](Basics.cs#L35)

### Composition
[Cat has an composed property Ancestor](Basics.cs#L44)

Try in Main: 
~~~C#
using Paragigms;

// inheritance 
var animal = new Animal("Bear");
animal.Eat();

var dog = new Dog("Rex");
dog.Eat();

// polymorphism
dog.Run();

// composition
var cat = new Cat("Kitty");
cat.Ancestor.Eat();
~~~