namespace DesignPatterns;

public class SingletonPattern
{
    private static SingletonPattern _instance;

    private SingletonPattern()
    {
        Console.WriteLine("Singleton instance is created");
    }

    public static SingletonPattern Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonPattern();
            }
            return _instance;
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine("Singleton instance method is called");
    }
}