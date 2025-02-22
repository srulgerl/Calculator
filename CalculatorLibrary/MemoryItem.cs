using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машины санах ойн нэгж.
    /// </summary>
    public class MemoryItem
    {
       
            /// <summary>
            /// Санах ойд хадгалагдсан тоо.
            /// </summary>
            public decimal Value { get; private set; }


            /// <summary>
            /// Санах ойн шинэ элемент үүсгэнэ.
            /// </summary>
            /// <param name="value">Хадгалагдах тоо</param>
            public MemoryItem(decimal value)
            {
                Value = value;
            }
        
    }
}
