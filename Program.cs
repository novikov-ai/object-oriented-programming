using InheritanceTypes;

var dog = new Dog("Rex");
// Eat() is invoking from the base class
dog.Eat(); // Rex: eating

// Sleep() is invoking from the derived class  
dog.Sleep(); // Rex: Zzz...

var cat = new Cat("Kitty");
// Eat() is overridden in the derived class
cat.Eat(); // I'm not hungry!