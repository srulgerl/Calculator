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
        private List<MemoryItem> memoryItems;

        /// <summary>
        /// Шинэ санах ой үүсгэнэ.
        /// </summary>
        public Memory()
        {
            memoryItems = new List<MemoryItem>();
        }

        /// <summary>
        /// Өгсөн утгыг санах ойд хадгална.
        /// </summary>
        /// <param name="item">Хадгалагдах утга</param>
        public void Store(MemoryItem item)
        {
            memoryItems.Add(item);
        }

        /// <summary>
        /// Санах ойд хадгалсан бүх утгуудыг буцаана.
        /// </summary>
        /// <returns>Хадгалсан утгуудын жагсаалт</returns>
        public void GetHistory()
        {
            foreach (var item in memoryItems)
            {
                Console.WriteLine($"{item.Value}");
            }
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
