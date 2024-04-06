namespace MethodsInvokation
{
    public class Dummy
    {
        public virtual void Do() => System.Console.WriteLine("Dummy does");

        public void Make(string value) => System.Console.WriteLine($"Dummy made: {value}");
    }

    public class DerivedDummy : Dummy
    {
        public override void Do() => System.Console.WriteLine("DerivedDummy does");


        public void Make(int value) => System.Console.WriteLine($"DerivedDummy made: {value}");

        public void SomethingNew() => System.Console.WriteLine("Derived new!");
    }
}