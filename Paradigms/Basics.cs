namespace Paragigms
{
    // Animal is a base class
    public class Animal
    {
        protected readonly string _name;
        public Animal()
        {
            _name = "Animal";
        }
        public Animal(string name)
        {
            this._name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{_name}: eating");
        }

        // The Run method is virtual, so we can rewrite it in derived class
        public virtual void Run()
        {
            Console.WriteLine($"{_name}: running!");
        } 
    }

    // Dog is a derived clas and it inherits the properties and methods
    public class Dog: Animal
    {
        public Dog(string name): base(name)
        {
        }

        // Override the Run method with our own implementation
        public override void Run()
        {
            Console.WriteLine($"{_name}: Zzz...");
        }
    }

    // Cat has an Animal class composed in Ancestor
    public class Cat
    {
        public readonly Animal Ancestor;
        public Cat(string name)
        {
            Ancestor = new Animal(name);
        }
    }
}