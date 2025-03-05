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
    void Subtract(decimal n);

    /// <summary>
    /// Нэмэх үйлдэл хийнэ.
    /// </summary>
    /// <param name="m">Нэмэгдэхүүн</param>
    void Add(decimal m);
}


