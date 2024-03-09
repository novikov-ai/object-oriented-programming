namespace DynamicCohesion {
    public class Vehicle {
        public virtual void Run(int miles){
            Console.WriteLine($"The vehicle drove about {miles} yesterday");
        }
    }

    public class Moto : Vehicle {
        public void Run(string town){
             Console.WriteLine($"The vehicle drove to {town} yesterday");
        }

        public override void Run(int miles)
        {
            Console.WriteLine($"The MOTO drove about {miles} yesterday");
        }
    }
}