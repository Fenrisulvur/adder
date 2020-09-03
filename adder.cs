using System;

namespace Calculator 
{
    static void Main(string[] args)
    {
        double a, b;
        a = Convert.ToDouble(AssemblyLoadEventArgs[0]);
        b = Convert.ToDouble(AssemblyLoadEventArgs[1]);
        double c = a+b;
        Console.Out.WriteLine("Result is"+c);
    }
}