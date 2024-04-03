namespace TaxonomyConflict
{
    public class Vehicle
    {
        public string? Brand { get; set; }
        public int Weight { get; set; }

        private readonly Transmission _transmission;

        public Vehicle(Transmission transmission)
        {
            this._transmission = transmission;
        }

        public void ShiftGear()
        {
            this._transmission.ShiftGear();
        }

        public void Drive()
        {
            Console.WriteLine("Driving forward");
        }

        public void Reverse()
        {
            Console.WriteLine("Driving back");
        }
    }

    public class Transmission
    {
        public virtual void ShiftGear()
        {
            Console.WriteLine("Gear is shifting...");
        }
    }
}