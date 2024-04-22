namespace InheritanceCategories.V3
{
    public class CustomPC : Computer
    {
        public CustomPC(IProcessor processor) : base(processor) { }

        public Graphics GraphicsCard { get; set; }
        public Memory MemoryCard { get; set; }
    }

    public class Graphics
    {
        public string Name { get; set; }
    }

    public class Memory
    {
        public string Name { get; set; }
        public string RAM { get; set; }
    }
}