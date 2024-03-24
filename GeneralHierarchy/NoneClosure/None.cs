namespace GeneralHierarchy.NoneClosure
{
    public sealed class None : Any, IDog, ICat
    {
        public void Bark() { }

        public void Purr() { }
    }
}