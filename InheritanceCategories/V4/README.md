# Наследование вида

Для проектирования наследников класса `Animal` применяем наследование вида, так как имеется несколько **равнозначных** критериев классификации (Отряд и Класс), и которые планируется комбинировать вместе. 

Таким образом, составляем отношение has-a, при котором класс `Animal` содержит в равнозначной степени и `Order`, и `Class`, позволяя гибко использовать функциональность обоих. 

~~~C#
public class Animal
{
    public Order Order { get; set; }
    public Class Class { get; set; }

    public void Sleep() { }
}
public class Order
{
    public virtual void Eat() { }
}

public class Carnivora : Order
{
    public override void Eat()
    {
        System.Console.WriteLine("Eating flesh...");
    }
}

public class Herbivory : Order
{
    public override void Eat()
    {
        System.Console.WriteLine("Eating plant...");
    }
}

public class Bear : Carnivora
{
    public void Hunt() { }
}

public class Horse : Herbivory
{
    public void Run() { }
}

public class Class
{

}

public class Mammalia : Class
{
    public void MilkFeeding() { }
}

public class Amphibia : Class
{
    public void Swim() { }
}
~~~