using GeneralHierarchy.NoneClosure;

IDog dog = new Dog();
dog.Bark();

ICat cat = new Cat();
cat.Purr();

var none = new None();

dog = none;
dog.Bark();

cat = none;
cat.Purr();