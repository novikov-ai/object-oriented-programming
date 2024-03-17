# Запрет переопределения методов в потомках

Ключевое слово `sealed` служит для запрета переопределения виртуальных методов в производном классе. 

~~~C#
namespace GeneralHierarchy.OpenClosedPrinciple
{
    public class General
    {
        public virtual void Do()
        {
            System.Console.WriteLine("Invokation from General");
        }
    }

    public class Derived: General
    {
        public sealed override void Do()
        {
            System.Console.WriteLine("Invokation from DerivedSealed");
        }
    }

    public class CantOverride: Derived
    {
        // error CS0239
        // public override void Do()
        // {
        //     System.Console.WriteLine("Invokation from CantOverride");
        // }
    }
}
~~~

Однако, если мы все-таки хотим реализовать метод для класса с таким же названием, то есть возможность использовать ключевое слово `new`: 

~~~C#
public class CantOverride: Derived
    {
        public new void Do()
        {
            System.Console.WriteLine("Invokation from CantOverride");
        }
    }
~~~

Но делать это можно только в исключительных ситуация, так как здесь мы уходим от классического полиморфизма и вместо этого скрываем реализацию предка и полностью перезаписываем метод. 

Такой подход относится к "плохим" практикам и в серьезных проектах с большой глубиной наследования может сильно запутать код.

Например, метод `public new void Do()` в классе `CantOverride` не переопределяет метод базового класса, полиморфизма не происходит и мы получаем поведение, которое не ожидали:  

~~~C#
General dd = new Derived();
dd.Do(); // Invokation from Derived

General ddd = new CantOverride();
ddd.Do(); // Invokation from Derived

General dddd = new DerivedFromCantOverride();
dddd.Do(); // Invokation from Derived
~~~