using System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DeveloperInfoAttribute : Attribute
{
    public string DeveloperName { get; }    
    public DeveloperInfoAttribute(string developerName)
    {
        DeveloperName = developerName;
    }
}

class ConstructorSample
{
    public int a;
    public int b;
    [DeveloperInfo("Yamini")]

    public void MethodSample()
    {
      
    }

    public ConstructorSample(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(ConstructorSample);

        DisplayDeveloperInfo(type.GetCustomAttributes(true), type.Name);

        var methods = type.GetMethods();
        
        foreach (var method in methods)
        {
            DisplayDeveloperInfo(method.GetCustomAttributes(true), method.Name);
            Console.WriteLine("Method Used");

            Console.WriteLine(method.Name);
        }

        var constructors = type.GetConstructors();
        foreach (var constructor in constructors)
        {
            DisplayDeveloperInfo(constructor.GetCustomAttributes(true), constructor.Name);
            Console.WriteLine("\n Constructor Used");
            Console.WriteLine(constructor.Name);
        }

        Console.ReadLine();
    }

    static void DisplayDeveloperInfo(object[] attributes, string memberName)
    {
        foreach (var attribute in attributes)
        {
            if (attribute is DeveloperInfoAttribute developerInfo)
            {
                Console.WriteLine($"Developer: {developerInfo.DeveloperName}");
                Console.WriteLine($"Associated Method: {memberName}");
                Console.WriteLine();
            }
        }
    }
}
