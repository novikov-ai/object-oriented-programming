# Язык программирования C# поддерживает 5 принципов повтороного использования модулей. 

1. [Инициализация модуля с базовым типом и параметризацией](TypeParametric/Modules.cs)

Пример использования:
~~~C#
var numbers = new TypeParametrics.Elements<int>();
var numbersList = numbers.Append(123, 456, 999);

numbersList.ForEach(x => Console.WriteLine(x));

var words = new TypeParametrics.Elements<string>();
var wordsList = words.Append("hello", "world");

wordsList.ForEach(x => Console.WriteLine(x));
~~~

2. Новый модуль может объединять несколько функций, которые активно обращаются друг к другу;

Модуль `TypeParametrics` содержит функцию `Append()` и `DisplayStatus()`, одна из которых вызывает другую.

3. Модуль `NestedModule` входит в семейство `TypeParametrics` и позволяет решает более узкие задачи, которые не удалось решить на верхнем уровне.

4. Модуль `Tools` может динамически (полиморфно) выбирать нужную реализацию в зависимости от типов аргументов функций класса `Summer`: 
~~~C#
var sumNumbers = TypeParametrics.Summer.DoSum(1,2,3);
Console.WriteLine($"Sum is {sumNumbers}");

var sumLetters = TypeParametrics.Summer.DoSum("A", "B", "C");
Console.WriteLine($"Sum is {sumLetters}");
~~~

5. Модуль `Tech` интегрирует в себе общее поведение нескольких модулей: `Cars` и `Planes`, определяя его абстрактным классом `Engine`. При этом поведение может различаться деталями.

~~~C#
namespace Tech
{
    public abstract class Engine
    {
        public int Volume; 
        public abstract void Start();
    }

    namespace Cars
    {
        public class BMW: Engine
        {
            public override void Start()
            {
                Console.WriteLine("BMW engine starts");
            }
        } 
    }

    namespace Planes
    {
        public class Boeing: Engine
        {
            public override void Start()
            {
                Console.WriteLine("Boeing engines start!");
            }
        }
    }
}
~~~