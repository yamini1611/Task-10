using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Reflection
    {
        static void Main(string[] args)
        {
            int integer = 5;
            float floatvalue = 5.6f;
            char charvalue = 'a';    
            bool boolval = false;

            DisplayMetaData(integer);
            DisplayMetaData(floatvalue);
            DisplayMetaData(charvalue);
         
            DisplayMetaData(boolval);

        }

        static void DisplayMetaData(object value)
        {
            Type type = value.GetType();
            Console.WriteLine($"Type:{type}");
            Console.WriteLine($"Full Name :{type.FullName}");
            Console.WriteLine($"Is Value : {type.IsValueType}");
            Console.WriteLine($"Is Primitive : {type.IsPrimitive}");
            Console.WriteLine($"Is Array :{type.IsArray}");
            Console.WriteLine($"IS String :{type.Attributes}");
           Console.ReadLine();
        }
    }
}

namespace MathClass
{
  class Mathreflection
    {
        static void Main(string[] args)
        {
            Type type = typeof(Math);
            MethodInfo[] methods = type.GetMethods();

            HashSet<string> names = new HashSet<string>();


            foreach(var method in  methods)
            {
                string methodname = method.Name;
                if(!names.Contains(methodname))
                {
                    names.Add(methodname);
                    Console.WriteLine("Methods Used");
                 Console.WriteLine("Method Name  : " + methodname);

                }
            }
            Console.ReadLine() ;
        }
    }
}

namespace methods
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Type currentType = typeof(Program);
            MethodInfo[] methods = currentType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
            foreach (var method in methods)
            {
                Console.WriteLine($"Method Name: {method.Name}");
            }
            Console.ReadLine();
        }

        public void Method1()
        {
            Console.WriteLine("This is MyMethod.");
        }

        public  void Method2()
        {
            Console.WriteLine("This is AnotherMethod.");
        }
    }

}