using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;
/// <summary>
/// Тооны машины үндсэн хийсвэр класс.
/// </summary>
public abstract class AbsCalculator
{
    /// <summary>
    /// Тооны машины хамгийн сүүлийн тооцооллын үр дүн
    /// </summary>
    public decimal Result { get; protected set; }
}
