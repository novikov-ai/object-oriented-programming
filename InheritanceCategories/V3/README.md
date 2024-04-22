# Категории наследования

### Наследование реализации

Класс-потом наследует полностью реализованный класс, добавляя свою уникальную абстракцию структуры данных. 

Наследуемся от класса `Computer`, который реализует наследование с конкретизацией и добавляем в `CustomPC` новые абстрактные структуры данных.

~~~C#
public abstract class Machine
{
    public abstract int Process();
}

public interface IProcessor
{
    public int Process();
}

public class Computer : Machine
{
    public Computer(IProcessor processor)
    {
        _processor = processor;
    }
    private IProcessor _processor { get; set; }

    public override int Process()
    {
        return _processor.Process();
    }
}
~~~

~~~C#
public class CustomPC : Computer
{
    public CustomPC(IProcessor processor) : base(processor) { }

    public Graphics GraphicsCard { get; set; }
    public Memory MemoryCard { get; set; }
}

public class Graphics
{
    public string Name { get; set; }
}

public class Memory
{
    public string Name { get; set; }
    public string RAM { get; set; }
}
~~~

### Льготное наследование

Класс-предок содержит стандартный набор компонентов, объединенных в целое для удобства, а наследники реализуют частные случаи. 

`Status` задает набор стандартных компонентов для работы со статусом. Он закрыт для изменения. Используем льготное наследование, чтобы специфицировать частные случаи, например, `Test` переопределяет лейбл статуса, но использует все основные методы родителя. 
 
~~~C#
public class Status
{
    public const string NotStarted = "not started";
    public const string InProgress = "in progress";
    public const string Done = "done";

    public void Display() { }
    public void Change() { }
}

public class Test : Status
{
    public const string InTest = "in test";
}
~~~