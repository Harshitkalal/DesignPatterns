namespace DesignPatterns.FactoryPattern;

public  static class LoggerFactory
{
    public static ILogger GetLogger(string loggerName)
    {
        return loggerName switch
        {
            "FileLogger" => new FileLogger(),
            "DatabaseLogger" => new DataBaseLogger(),
            "ElkLogger" => new ElkLogger(),
            _ => throw new NotImplementedException(loggerName)
        };
    }
}