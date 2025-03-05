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
    public decimal Result { get; protected set; } = 0;

    protected Memory Memory { get; private set; }

    public AbsCalculator(){
        Memory = new Memory();
    }
    
    protected void SaveToMemory()
    {
        Memory.Store(new MemoryItem(Result));
    }
    public void ShowMemory()
    {
        Memory.GetHistory();
    }

}
