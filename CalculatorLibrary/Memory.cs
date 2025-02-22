using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Memory
    {
        private List<MemoryItem> memoryItems;

        /// <summary>
        /// Шинэ санах ой үүсгэнэ.
        /// </summary>
        public Memory()
        {
            memoryItems = new List<MemoryItem>();
        }

        /// <summary>
        /// Утгыг санах ойд хадгална.
        /// </summary>
        /// <param name="value">Хадгалагдах утга</param>
        public void Store(decimal value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        /// <summary>
        /// Санах ойн түүхийг буцаана.
        /// </summary>
        /// <returns>Хадгалсан утгуудын жагсаалт</returns>
        public List<MemoryItem> GetHistory()
        {
            return memoryItems;
        }

    

        /// <summary>
        /// Санах ойг цэвэрлэнэ.
        /// </summary>
        public void Clear()
        {
            memoryItems.Clear();
        }
    }
}
