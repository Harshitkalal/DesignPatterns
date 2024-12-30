namespace DesignPatterns.FactoryPattern;

public class FileLogger :ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging into the file :{message}");
    }
}