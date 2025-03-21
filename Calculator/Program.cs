using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace CalculatorApp;

internal class Programs
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.Add(10);

        calculator.Subtract(3);

        calculator.SaveToMemory();

        calculator.Add(5);

        calculator.SaveToMemory();

        var memoryItems = calculator.GetMemoryItems();
        foreach (var item in memoryItems)
        {
            Console.WriteLine(item.Value);
        }

        calculator.ClearMemory();
        Console.WriteLine("Memory cleared.");

        memoryItems = calculator.GetMemoryItems();
        if (memoryItems.Count == 0)
        {
            Console.WriteLine("Memory is empty.");
        }
    }
}

