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
    public class MezzoreallaSticks : Side
    {
        /// <summary>
        /// The name of the mozzarealla sticks
        /// </summary>
        public override string Name { get => $"{Size} Mezzorealla Sticks"; }

        /// <summary>
        /// The price of the mozzarealla sticks
        /// </summary>
        public override decimal Price
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
        public override uint Calories
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
