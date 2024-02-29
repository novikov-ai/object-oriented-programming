// Инициирование базового модуля с возможностью параметризации
var numbers = new TypeParametrics.Elements<int>();
var numbersList = numbers.Append(123, 456, 999);

var words = new TypeParametrics.Elements<string>();
var wordsList = words.Append("hello", "world");

// Модуль входит в семейство модулей
TypeParametrics.NestedModule.Tool.Do();

var sumNumbers = Tools.Summer.DoSum(1,2,3);
Console.WriteLine($"Sum is {sumNumbers}");

var sumLetters = Tools.Summer.DoSum("A", "B", "C");
Console.WriteLine($"Sum is {sumLetters}");

// Модуль интегрирует в себе несколько модулей
var car = new Tech.Cars.BMW();
car.Start();

var plane = new Tech.Planes.Boeing();
plane.Start();