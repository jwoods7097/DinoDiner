using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing the Triceritots tater tots
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// The name of the tater tots
        /// </summary>
        public override string Name { get => $"{Size} Triceritots"; }

        /// <summary>
        /// The price of the tater tots
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
        /// The calories of the tater tots
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == ServingSize.Medium) return 409;
                if (Size == ServingSize.Large) return 583;
                return 351;
            }
        }
    }
}
