namespace TypeParametrics
{
    public class Elements<T>
    {
        private List<T> _elements = [];
        public Elements()
        {
           this._elements = [];
        }
        public List<T> Append(params T []elements)
        {
           foreach (T p in elements)
           {
            this._elements.Add(p);
           }

        this.DisplayStatus();
           return this._elements;
        }

        private void DisplayStatus()
        {
            Console.WriteLine("All elements:");
            this._elements.ForEach(x => Console.WriteLine(x));
        }
    }

    namespace NestedModule
    {
        public class Tool
        {
            public static void Do()
            {
                Console.WriteLine("did nothing");
            }
        }
    }
}

namespace Tools
{
    public static class Summer
    {
        public static string DoSum(params string []args)
        {
            var sum = "";

            foreach (string arg in args)
            {
                sum += arg;
            }

            return sum;
        }

         public static int DoSum(params int []args)
        {
            var sum = 0;

            foreach (int arg in args)
            {
                sum += arg;
            }

            return sum;
        }
    }
}

namespace Tech
{
    public abstract class Engine
    {
        public int Volume; 
        public abstract void Start();
    }

    namespace Cars
    {
        public class BMW: Engine
        {
            public override void Start()
            {
                Console.WriteLine("BMW engine starts");
            }
        } 
    }

    namespace Planes
    {
        public class Boeing: Engine
        {
            public override void Start()
            {
                Console.WriteLine("Boeing engines start!");
            }
        }
    }
}