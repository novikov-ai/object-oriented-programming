namespace CovarianceContravariance{
    public class Base{
        public string Hello = "base hello";

        public static void Magic(Base b){
            Console.WriteLine($"Magic is happening here: {b.Hello}");
        }
    }

    public class Derived: Base{
        public new string Hello = "derived hello";
    }

    public class Doer{
        public static void Do(Derived arg){
            Console.WriteLine($"Do {arg.Hello}!");
        }
        public static void Make(Action<Derived> act){
            var b = new Derived();
            act(b);
        }
    }
}