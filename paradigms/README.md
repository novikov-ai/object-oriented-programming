# Basics paradigms

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