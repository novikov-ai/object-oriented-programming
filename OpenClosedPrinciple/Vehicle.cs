namespace OpenClosedPrinciple
{
    public abstract class Vehicle
    {
        public string Brand {get;set;}
        public Vehicle(string brand)
        {
            this.Brand = brand;
        }
        public abstract void Drive();
        public abstract void Reverse();
    }
}