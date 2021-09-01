using System;

namespace ConsoleTestCalculator
{
    public class Class1
    {
        double num1 = 40;
        double num2 = 30;
        double res;
        public void add()
        {
            res = num1 + num2;
            Console.WriteLine("Addition of Two num is: " + res);
        }

        public void sub()
        {

            res = num1 - num2;
            Console.WriteLine("Substraction of Two num is: " + res);
        }

        public void mul()
        {
            res = num1 * num2;
            Console.WriteLine("Multiplication of Two num is: " + res);
        }

    }
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
