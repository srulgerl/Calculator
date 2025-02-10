using System;
using 
namespace Calculator;

internal class Program : Calculator, IAdd, ISubstract
{
    static void Main(string[] args)
    {

        Calculator cal = new Calculator(1,2);
    }
}
