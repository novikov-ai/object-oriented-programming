# Ковариантность и контравариантность

В C# есть поддержка ковариантности и контрвариантности. 

### Ковариантность

Позволяет использовать более производный тип, чем изначально указанный.

Допускается присвоение переменной с типом списка базового класса к списку с более производными типами:

~~~C#
public class Base{
        public string Hello = "base hello";

        public static void Magic(Base b){
            Console.WriteLine($"Magic is happening here: {b.Hello}");
        }
    }

    public class Derived: Base{
        public new string Hello = "derived hello";
    }
~~~

~~~C#
IEnumerable<Base> example;

example = new List<Base>();
example = new List<Derived>();
~~~

### Контравариантность

Допускается использование более универсальных типов (с меньшей глубиной наследования)

~~~C#
public class Doer{
        public static void Do(Derived arg){
            Console.WriteLine($"Do {arg.Hello}!");
        }
        public static void Make(Action<Derived> act){
            var b = new Derived();
            act(b);
        }
    }
~~~

Контрвариантность на примере делегатов:

~~~C#
Doer.Make(Base.Magic); // out: Magic is happening here: base hello
Doer.Make(Derived.Magic); // out: Magic is happening here: base hello
~~~

Контрвариантность в массивах:

~~~C#
string[] arr = new string[5];
object[] arrObj = new object[5];

arrObj = arr;
~~~