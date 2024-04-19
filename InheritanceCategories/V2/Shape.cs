namespace InheritanceCategories.V2
{
    public class Shape
    {
        public float SizeA { get; set; }
        public float SizeB { get; set; }
        public virtual float Area()
        {
            return SizeA * SizeB;
        }

        public void Display(string value)
        {
            System.Console.WriteLine($"{value}");
        }
    }

    public class RestrictedArea : Shape
    {
        private const int _offset = 15;
        public override float Area()
        {
            return SizeA * SizeB * _offset;
        }

         public void Display(int value)
        {
            System.Console.WriteLine($"{value}");
        }
    }
}