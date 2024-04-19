namespace InheritanceCategories.V2
{
    public interface Engine
    {
        public void Start();
    }

    public class Vehicle
    {
        private Engine _engine { get; set; }
        public Vehicle(Engine engine)
        {
            _engine = engine;
        }
        public void Start()
        {
            _engine.Start();
        }
    }

    public class Mercedes : Vehicle
    {
        public Mercedes(Engine engine): base(engine){}
    }
}