namespace InheritanceCategories.V2
{
    public abstract class Fruit
    {
        public abstract void Grow();
    }

    public class Apple : Fruit
    {
        public override void Grow()
        {
            System.Console.WriteLine("Apple is growing...");
        }
    }
}