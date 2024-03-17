namespace GeneralHierarchy.OpenClosedPrinciple
{
    public class General
    {
        public virtual void Do()
        {
            System.Console.WriteLine("Invokation from General");
        }
    }

    public class Derived : General
    {
        public sealed override void Do()
        {
            System.Console.WriteLine("Invokation from DerivedSealed");
        }
    }

    public class CantOverride : Derived
    {
        // error CS0239
        // public override void Do()
        // {
        //     System.Console.WriteLine("Invokation from CantOverride");
        // }

        public new void Do()
        {
            System.Console.WriteLine("Invokation from CantOverride");
        }
    }
}