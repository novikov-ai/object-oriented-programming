namespace MethodHidingPolicy
{
    public class A
    {
        public void PublicDo() { }
        private void PrivateDo() { }
    }

    public class B : A
    {
    }
}