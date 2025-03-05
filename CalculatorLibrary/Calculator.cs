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
    /// өгсөн тоог нэмнэ
    /// </summary>
    /// <param name="m"></param>

    public void Add(decimal m)
    {
        Result += m;
        SaveToMemory();
    }
    /// <summary>
    /// өгсөн тоог хасна
    /// </summary>
    /// <param name="m"></param>

    public void Subtract(decimal m)
    {
        Result -= m;
        SaveToMemory();
    }
}

