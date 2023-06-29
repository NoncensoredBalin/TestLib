using System;
using System.Diagnostics.Metrics;
using TestLib;

namespace TestConsole 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCounter counter = new AreaCounter(new Circle(5));
            Console.WriteLine(counter.CountArea());
            counter = new AreaCounter(new Triangle(24, 7, 25));
            Console.WriteLine(counter.CountArea());
            counter = new AreaCounter(new Triangle(5, 7, 10));
            Console.WriteLine(counter.CountArea());
        }
    }
}