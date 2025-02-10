using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator;

internal class Calculator : AbsCalculator, IAdd, ISubstract
{
    Calculator cal;
     private Calculator(decimal n, decimal m)
    {

    }

    public decimal add()
    {
        return ((IAdd)cal).add();
    }
    public decimal substract()
    {
        return ((ISubstract)cal).substract();
    }
}
