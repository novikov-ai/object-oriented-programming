namespace TaxonomyConflict
{
    public class TransmissionManual : Transmission
    {
        public override void ShiftGear()
        {
            Console.WriteLine("Gear is shifting by one step manually");
        }
    }
}