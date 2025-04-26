using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машины санах ойн нэг нэгж.
    /// </summary>
    public class MemoryItem
    {

        /// <summary>
        /// Санах ойд хадгалагдсан утга.
        /// </summary>
        public decimal Value { get;  set; }


        /// <summary>
        /// Санах ойн шинэ элемент үүсгэнэ.
        /// </summary>
        /// <param name="value">Санах ойд хадгалагдах утга</param>
        public MemoryItem(decimal value)
        {
            Value = value;
        }
        /// <summary>
        /// Санах ойн утгаас өгөгдсөн утгыг хасна.
        /// </summary>
        /// <param name="x">Хасах утга</param>
        public void substractResult(decimal x)
        {
            Value -= x;
        }

        /// <summary>
        /// Санах ойн утгад өгөгдсөн утгыг нэмнэ.
        /// </summary>
        /// <param name="x">Нэмэх утга</param>
        public void AddResult(decimal x)
        {
            Value += x;
        }
       
    }
}
