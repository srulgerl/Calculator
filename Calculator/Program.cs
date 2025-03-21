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
  

    }
}

