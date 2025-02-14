using System;
 
namespace Calculator;

internal class Program : Calculator
{
    static void Main(string[] args)
    {
        var res = 0;
        Calculator cal = new Calculator();
        cal.Add(3);
        Console.WriteLine(cal.Result);
        //cal.substract(); 
    }
}
