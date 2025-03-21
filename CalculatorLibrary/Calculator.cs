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
    private Memory memory = new Memory();
    /// <summary>
    /// өгсөн тоог нэмнэ
    /// </summary>
    /// <param name="m">Нэмэх тоо</param>

    public void Add(decimal m)
    {
        Result += m;
    }
    /// <summary>
    /// өгсөн тоог хасна
    /// </summary>
    /// <param name="m">Хасах тоо</param>

    public void Subtract(decimal m)
    {
        Result -= m;
    }
    /// <summary>
    /// Одоогийн утгыг санах ойд хадгална
    /// </summary>
    public void SaveToMemory()
    {
        memory.SaveToMemory(Result);
    }

    /// <summary>
    /// Санах ойд хадгалсан утгуудын жагсаалтыг буцаана
    /// </summary>
    /// <returns>Хадгалсан утгуудын жагсаалт</returns>
    public List<MemoryItem> GetMemoryItems()
    {
        return memory.GetMemoryItems();
    }
    /// <summary>
    /// Санах ойг цэвэрлэж, бүх утгыг усгтана
    /// </summary>
    public void ClearMemory()
    {
        memory.Clear();
    }
}

