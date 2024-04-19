# Категории наследования

### Наследование вариаций

- Наследование с функциональной вариацией (переопределение родительского метода без изменения сигнатуры)
- Наследование с вариацией типа (переопределение сигнатуры родительского метода - перегрузка)

~~~C#
public class Shape
{
    public float SizeA { get; set; }
    public float SizeB { get; set; }
    public virtual float Area()
    {
        return SizeA * SizeB;
    }

    public void Display(string value)
    {
        System.Console.WriteLine($"{value}");
    }
}

public class RestrictedArea : Shape
{
    private const int _offset = 15;
    public override float Area()
    {
        return SizeA * SizeB * _offset;
    }

        public void Display(int value)
    {
        System.Console.WriteLine($"{value}");
    }
}
~~~

### Наследование с конкретизацией

Реализация родительского класса отложена (абстрактный), а конкретные реализации выполняются в классах-наследниках

~~~C#
public abstract class Fruit
{
    public abstract void Grow();
}

public class Apple : Fruit
{
    public override void Grow()
    {
        System.Console.WriteLine("Apple is growing...");
    }
}
~~~

### Структурное наследование

~~~C#
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
~~~