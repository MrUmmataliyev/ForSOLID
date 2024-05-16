using System.Reflection.Metadata;

public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}

public class SimplePrinter : IPrinter
{
    public void Print(Document d)
    {
        // Print logika
    }
}
