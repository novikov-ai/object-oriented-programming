# Basics paradigms

### Inheritance
[Dog is derived class from Animal](Basics.cs#L28)

### Polymorphism
[Dog overrides method Run provided from Animal](Basics.cs#L35)

### Composition
[Cat has an composed property Ancestor](Basics.cs#L44)

Let's Run in Main: 
~~~C#
using Paragigms;

// inheritance 
var animal = new Animal("Bear");
animal.Eat(); // Bear: eating
animal.Run(); // Bear: running!

var dog = new Dog("Rex");
dog.Eat(); // Rex: eating

// polymorphism
dog.Run(); // Rex: Zzz...

// composition
var cat = new Cat("Kitty");
cat.Ancestor.Eat(); // Kitty: eating
cat.Ancestor.Run(); // Kitty: running!
~~~