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

        cal.Add(10);
  
        cal.Add(4);

        cal.Subtract(6);

        cal.ShowMemory();
    }

}

