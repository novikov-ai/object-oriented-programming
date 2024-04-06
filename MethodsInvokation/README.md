# Полиморфный и ковариантный вызовов метода

### Ковариантный вызов

В примере ниже ковариантный вызов метод происходит, когда переменную `dummy` инициируем производным от `Dummy` классом. Таким образом, возможна ковариантность. 

Однако, обозначив тип переменной базовым классом `Dummy`, мы ограничили возможные вызовы из производного класса и, например, метод `SomethingNew()` нам не доступен.

### Полиморфный вызов

Полиморфный вызов метода возможен, когда у нас появляется перегрузка метода. При этом важно не накладывать ограничения базового типа, если перегрузка у нас реализована в более производном классе. 

То есть, для полиморфного вызова нам необходимо инстанцировать класс типа `DerivedDummy`, чтобы была возможность использовать метод `Make()` из базового и производного класса. 

~~~C#
using MethodsInvokation;

// Covariance: 
Dummy dummy = new DerivedDummy();
dummy.Do(); // DerivedDummy does

// dummy.SomethingNew(); // can't invoke that

// Polymorphism:
DerivedDummy derivedDummy = new DerivedDummy();
derivedDummy.Make("hello"); // Dummy made: hello
derivedDummy.Make(123); // DerivedDummy made: 123
~~~

~~~C#
public class Dummy
    {
        public virtual void Do() => System.Console.WriteLine("Dummy does");

        public void Make(string value) => System.Console.WriteLine($"Dummy made: {value}");
    }

    public class DerivedDummy : Dummy
    {
        public override void Do() => System.Console.WriteLine("DerivedDummy does");


        public void Make(int value) => System.Console.WriteLine($"DerivedDummy made: {value}");

        public void SomethingNew() => System.Console.WriteLine("Derived new!");
    }
~~~