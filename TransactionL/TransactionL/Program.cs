// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public interface ISomeInterface
{
    void Amogus();
}

public class SomeClass : ISomeInterface
{
    [Transactional]
    public void Amogus()
    {
        Console.WriteLine("Amogus");
    }
}

public class TransactionalAttribute : Attribute
{
    
}