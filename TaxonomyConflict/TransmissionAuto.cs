namespace TaxonomyConflict
{
    public class TransmissionAuto: Transmission
    {
        public override void ShiftGear()
        {
            Console.WriteLine("Gear is shifting automatically");
        }
    }
}