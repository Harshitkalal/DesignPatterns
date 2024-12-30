// See https://aka.ms/new-console-template for more information

using DesignPatterns;
using DesignPatterns.FactoryPattern;

SingletonPattern singleton = SingletonPattern.Instance;
singleton.ShowMessage();
SingletonPattern singleton2 = SingletonPattern.Instance;    
singleton2.ShowMessage();

Console.WriteLine(object.ReferenceEquals(singleton, singleton2));

//  test factory pattern
string logTypeFile = "FileLogger";
string logTypeDatabase = "DatabaseLogger";
ILogger fileLogger = LoggerFactory.GetLogger(logTypeFile);
fileLogger.Log("Logging started!");
ILogger databaseLogger = LoggerFactory.GetLogger(logTypeDatabase);
databaseLogger.Log("Logging started!");
