using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;
/// <summary>
/// Нэмэх, хасах үйлдлийг тодорхойлсон интерфэйс
/// </summary>
public interface IOperations
{
    /// <summary>
    /// Хасах үйлдэл хийнэ.
    /// </summary>
    /// <param name="n">Хасагдагч</param>
    /// <param name="m">Хасагч</param>
    void Subtract(decimal n, decimal m);

    /// <summary>
    /// Нэмэх үйлдэл хийнэ.
    /// </summary>
    /// <param name="n">Нэмэгдэхүүн</param>
    /// <param name="m">Нэмэгдэхүүн</param>
    void Add(decimal n, decimal m);
}


