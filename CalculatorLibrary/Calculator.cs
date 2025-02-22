using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;

public class Calculator : AbsCalculator, IOperations
{

    public void Add(decimal m)
    {
        Result += m;
    }
    public void Add(decimal m, decimal n)
    {
        Result = m + n;
    }
    public void Subtract(decimal m)
    {
        Result -= m;
    }
    public void Subtract(decimal m, decimal n)
    {
        Result = m - n;
    }
}

