using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;

internal class Calculator : AbsCalculator, IOperations
{

    public void Add(decimal m)
    {
        Result += m;
    }
    public void Substract(decimal m)
    {
        Result -= m;
    }
}

