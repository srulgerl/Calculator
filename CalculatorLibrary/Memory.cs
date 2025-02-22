﻿using System;
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
        /// <param name="value">Хадгалагдах утга</param>
        public void Store(decimal value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        /// <summary>
        /// Санах ойд хадгалсан бүх утгуудыг буцаана.
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
