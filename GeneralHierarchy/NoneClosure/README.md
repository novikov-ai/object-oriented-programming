# Замыкание иерархии

C# не разрешает множественное наследование для классов. Разрешается наследоваться только от одного класса, но при этом есть механизм множественного наследования интерфейсов. 

Если мы хотим замкнуть все классы без наследников на общий, например, `None`, то нам нужно выстроить иерархию определенным образом.

Чтобы сделать наследником всех листьев в иерархии классов `None`, мы должны все классы организовывать с помощью интерфейсов, которые будут их специфицировать.

Так, например, если у нас в проекте есть 2 класса без наследников: `Dog` и `Cat`, то они должны быть описаны и унаследованы соответствующими интерфейсами `IDog` и `ICat`. 

~~~C#
namespace GeneralHierarchy.NoneClosure
{
    public interface IDog
    {
        public void Bark();
    }

    public class Dog: Animal, IDog
    {
        public void Bark()
        {
            System.Console.WriteLine("AW-AW-AW");
        }
    }
}
~~~

~~~C#
namespace GeneralHierarchy.NoneClosure
{
    public interface ICat
    {
        public void Purr();
    }

    public class Cat: Animal, ICat
    {
        public void Purr()
        {
            System.Console.WriteLine("mr-mr-mr");
        }
    }
}
~~~

Таким образом, замыкающий класс `None` теперь может унаследоваться от интерфейсов, описывающих классы-листья. 

~~~C#
namespace GeneralHierarchy.NoneClosure
{
    public sealed class None : IDog, ICat
    {
        public void Bark() { }

        public void Purr() { }
    }
}
~~~

Используя такой подход, нам открывается возможность полиморфного использования Void в качестве значения переменной любого типа:

~~~C#
using GeneralHierarchy.NoneClosure;

IDog dog = new Dog();
dog.Bark();

ICat cat = new Cat();
cat.Purr();

var none = new None();

dog = none;
dog.Bark();

cat = none;
cat.Purr();
~~~