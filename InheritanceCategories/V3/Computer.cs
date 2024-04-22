namespace InheritanceCategories.V3
{
    public abstract class Machine
    {
        public abstract int Process();
    }

    public interface IProcessor
    {
        public int Process();
    }

    public class Computer : Machine
    {
        public Computer(IProcessor processor)
        {
            _processor = processor;
        }
        private IProcessor _processor { get; set; }

        public override int Process()
        {
            return _processor.Process();
        }
    }
}