    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машины санах ой. Санах ойн memory item-уудыг агуулж, зохицуулна.
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Санах ойн жагсаалт.
        /// </summary>
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

      

        /// <summary>
        /// Өгсөн утгыг санах ойд хадгална.
        /// </summary>
        /// <param name="item">Хадгалагдах утга</param>
        public void SaveToMemory(decimal value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        /// <summary>
        /// Санах ойд хадгалсан бүх утгуудыг буцаана.
        /// </summary>
        /// <returns>Хадгалсан утгуудын жагсаалт</returns>
        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }

        /// <summary>
        /// Санах ойг цэвэрлэнэ.
        /// </summary>
        public void ClearMemory()
        {
            memoryItems.Clear();
        }
    }
}
