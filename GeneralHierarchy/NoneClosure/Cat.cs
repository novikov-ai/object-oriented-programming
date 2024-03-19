namespace GeneralHierarchy.NoneClosure
{
    public interface ICat
    {
        public void Purr();
    }

    public class Cat: Animal, ICat
    {
        public void Purr()
        {
            System.Console.WriteLine("mr-mr-mr");
        }
    }
}