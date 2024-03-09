### Динамическое связывание

Класс родитель - `Vehicle` реализует виртуальный метод `Run()`. 

Унаследуем класс `Moto` от `Vehicle`.

За счет того, что в родительском класс метод `Run` виртуален, то наследник `Vehicle` может переопределить метод, специализируя класс. 

Также нам доступна полиморфное поведение - перегрузка методов `Run` разными типами (int, string и др.). 

За счет данных механизмов в C# достигается динамическое связывание вызываемого метода с нужной реализацией во время исполнения кода. 

~~~C#
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
~~~

~~~C#
using DynamicCohesion;

var vehicle = new Vehicle();
vehicle.Run(15); // Out: The vehicle drove about 15 yesterday

var moto = new Moto();
moto.Run(15); // Out: The MOTO drove about 15 yesterday
moto.Run("Dune"); // Out: The vehicle drove to Dune yesterday
~~~