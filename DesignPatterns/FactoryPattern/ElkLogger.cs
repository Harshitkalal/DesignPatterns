namespace DesignPatterns.FactoryPattern;

public class ElkLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to ELK: {message}");
    }
}