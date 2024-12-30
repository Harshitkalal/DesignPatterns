// See https://aka.ms/new-console-template for more information

using DesignPatterns;

SingletonPattern singleton = SingletonPattern.Instance;
singleton.ShowMessage();
SingletonPattern singleton2 = SingletonPattern.Instance;    
singleton2.ShowMessage();

Console.WriteLine(object.ReferenceEquals(singleton, singleton2));