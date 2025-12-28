using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_StaticPolymorphism
{
    class Calculator
    {
        //Polymorphism
        //Static Polymorphism(Compile-time polymorphism)
        //method-overloading
        public int Add(int a,int b)
        {
            return a + b;
        }
        //over-loading allows working with different number of parameters
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }
        //over-loading allows working with different data types of parameters
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(float a, double b)
        {
            return a + b;
        }
        //over-loading allows working with different sequence of parameters

        public double Add(double a, float b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine(c1.Add(45,67));
            Console.WriteLine(c1.Add(26,76,24));
            Console.WriteLine(c1.Add(45.5, 54.8));
            Console.WriteLine(c1.Add(2.7F, 76.34));
            Console.WriteLine(c1.Add(45.456, 67.1F));
            

        }
    }
}
