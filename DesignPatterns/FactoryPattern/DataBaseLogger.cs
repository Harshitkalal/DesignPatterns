namespace DesignPatterns.FactoryPattern;

public class DataBaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging into the Database: {message}");
    }
}