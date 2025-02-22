using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorApp;

internal class Program
{
    public static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        Memory memory = new Memory();

        cal.Add(10,10);
        memory.Store(cal.Result);
        Console.WriteLine($"{cal.Result}"); 

        cal.Add(cal.Result, 4);
        memory.Store(cal.Result);
        Console.WriteLine($"{cal.Result}"); 

        cal.Subtract(6);
        memory.Store(cal.Result);
        Console.WriteLine($"{cal.Result}");

        Console.WriteLine("\nSanah oin tuuh:");
        foreach (var item in memory.GetHistory())
        {
            Console.WriteLine($"Hadgalsan utga: {item.Value}");
        }

        memory.Clear();
    }

}

