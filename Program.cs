using System;
using ClassLibraryDemoCalculator;
namespace ConsoleTestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Class1 obj1 = new Class1();
            obj1.add();
            obj1.sub();
            obj1.mul();
           
        }
    }
}
