namespace InheritanceCategories.V4
{
    public class Animal
    {
        public Order Order { get; set; }
        public Class Class { get; set; }
        
        public void Sleep() { }
    }
    public class Order
    {
        public virtual void Eat() { }
    }

    public class Carnivora : Order
    {
        public override void Eat()
        {
            System.Console.WriteLine("Eating flesh...");
        }
    }

    public class Herbivory : Order
    {
        public override void Eat()
        {
            System.Console.WriteLine("Eating plant...");
        }
    }

    public class Bear : Carnivora
    {
        public void Hunt() { }
    }

    public class Horse : Herbivory
    {
        public void Run() { }
    }

    public class Class
    {

    }

    public class Mammalia : Class
    {
        public void MilkFeeding() { }
    }

    public class Amphibia : Class
    {
        public void Swim() { }
    }
}