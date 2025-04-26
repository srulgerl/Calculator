    using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// Өгсөн утгыг санах ойд хадгална.(MS)
        /// </summary>
        /// <param name="item">Хадгалагдах утга</param>
        public void SaveToMemory(decimal value)
        {
            memoryItems.Add(new MemoryItem(value));
        }


        /// <summary>
        /// Санах ойг цэвэрлэнэ.(MC)
        /// </summary>
        public void ClearMemory()
        {
            memoryItems.Clear();
        }
         public void RemoveMemoryItem(MemoryItem item)
        {
            memoryItems.Remove(item);
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
        /// M+
        /// </summary>
        /// <param name="value"></param>
        public void Add(decimal value)
        {
            var last = memoryItems.LastOrDefault() ?? new MemoryItem(0);

            var next = new MemoryItem(last.Value);
            next.AddResult(value);
            memoryItems.Add(next);

        }

        /// <summary>
        /// M-
        /// </summary>
        /// <param name="value"></param>
        public void Substract(decimal value)
        {
            var last = memoryItems.LastOrDefault() ?? new MemoryItem(0);

            var next = new MemoryItem(last.Value);
            next.substractResult(value);
            memoryItems.Add(next);

        }

        

    }

}
