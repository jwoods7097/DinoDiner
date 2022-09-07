using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing the Mezzorealla Sticks mozzarealla sticks
    /// </summary>
    public class MezzoreallaSticks
    {
        /// <summary>
        /// The name of the mozzarealla sticks
        /// </summary>
        public string Name { get => $"{Size} Mezzorealla Sticks"; }

        /// <summary>
        /// The serving size of the mozzarealla sticks
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// The price of the mozzarealla sticks
        /// </summary>
        public decimal Price
        {
            get
            {
                if (Size == ServingSize.Medium) return 4.00m;
                if (Size == ServingSize.Large) return 5.25m;
                return 3.50m;
            }
        }

        /// <summary>
        /// The calories of the mozzarealla sticks
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == ServingSize.Medium) return 620;
                if (Size == ServingSize.Large) return 730;
                return 530;
            }
        }
    }
}
