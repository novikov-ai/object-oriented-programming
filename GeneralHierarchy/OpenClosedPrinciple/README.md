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

Но делать это можно только в исключительных ситуациях. Такой подход относится к "плохим" практикам и в большим проектах с большой глубиной наследования может сильно запутать код.