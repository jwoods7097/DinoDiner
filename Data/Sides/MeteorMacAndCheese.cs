using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing Meteor Mac and Cheese
    /// </summary>
    public class MeteorMacAndCheese
    {
        /// <summary>
        /// The name of the mac and cheese
        /// </summary>
        public string Name { get => $"{Size} Meteor Mac & Cheese"; }

        /// <summary>
        /// The serving size of the mac and cheese
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// The price of the mac and cheese
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
        /// The calories of the mac and cheese
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == ServingSize.Medium) return 510;
                if (Size == ServingSize.Large) return 700;
                return 425;
            }
        }
    }
}
