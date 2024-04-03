# Решение конфликта таксономии

На примере `Vehicle` вместо задания общего поля с конкретным значением, определяющего тип трансмиссии, задаем общий класс `Transmission`. 

Из `Transmission` строим иерархию всех возможных коробок передач с возможностью расширения. Так мы наследуем ручную и автоматическую коробку передач от `Transmission`, при этом основной класс `Vehicle` ничего про это не знает. Мы пользуемся преимуществом рантайма за счет применения паттерна стратегии, а также избавляем себя от потенциальных условий, которые могли быть жестко завязаны на заданный атрибут.

~~~C#
var vehicleManual = new Vehicle(new TransmissionManual());
vehicleManual.ShiftGear();

var vehicleAuto = new Vehicle(new TransmissionAuto());
vehicleAuto.ShiftGear();
~~~

~~~C#
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
~~~

~~~C#
  public class TransmissionManual : Transmission
    {
        public override void ShiftGear()
        {
            Console.WriteLine("Gear is shifting by one step manually");
        }
    }
~~~

~~~C#
public class TransmissionAuto: Transmission
    {
        public override void ShiftGear()
        {
            Console.WriteLine("Gear is shifting automatically");
        }
    }
~~~