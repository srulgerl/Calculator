using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;
/// <summary>
/// Үндсэн тооны машин. Нэмэх, хасах үйлдэл хийнэ.
/// </summary>
public class Calculator : AbsCalculator, IOperations
{
    /// <summary>
    /// өгсөн 2 тоог хооронд нь нэмнэ
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>

    public void Add(decimal m, decimal n)
    {
        Result = m + n;
    }
    /// <summary>
    /// өгсөн 2 тоог хооронд нь хасна
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    public void Subtract(decimal m, decimal n)
    {
        Result = m - n;
    }
}

