namespace GeneralHierarchy.NoneClosure
{
    public interface IDog
    {
        public void Bark();
    }

    public class Dog: Animal, IDog
    {
        public void Bark()
        {
            System.Console.WriteLine("AW-AW-AW");
        }
    }
}