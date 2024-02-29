namespace OpenClosedPrinciple
{
    public class Mercedes: Vehicle
    {
        public Mercedes(string brand):base(brand){}
        public override void Drive()
        {
            Console.WriteLine($"{Brand} is driving");
        }

        public override void Reverse()
        {
           Console.WriteLine($"{Brand} is reversing");
        }

        public void Drift()
        {
           Console.WriteLine($"{Brand} is drifting!");
        }
    }
}