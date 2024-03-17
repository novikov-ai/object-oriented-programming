namespace InheritanceTypes
{
    public class Animal
    {
        protected readonly string _name;
        
        public Animal(string name)
        {
            _name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{_name}: eating");
        }
    }

    public class Dog: Animal
    {
        public Dog(string name): base(name){}

        // Expand the base class with a new method
        public void Sleep()
        {
            Console.WriteLine($"{_name}: Zzz...");
        }
    }

    public class Cat: Animal
    {
        public Cat(string name): base(name){}

        // The method Eat specializes the Parent method
        public override void Eat()
        {
            Console.WriteLine($"{_name}: I'm not hungry!");
        }
    }
}