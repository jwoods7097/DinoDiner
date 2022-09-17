using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing Fryceritops french fries
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// The name of the fries
        /// </summary>
        public override string Name { get => $"{Size} Fryceritops"; }

        /// <summary>
        /// Indicates that the fries are salted
        /// </summary>
        public bool Salt { get; set; } = true;

        /// <summary>
        /// Indicates that the fries are served with fry sauce
        /// </summary>
        public bool Sauce { get; set; } = false;

        /// <summary>
        /// The price of the fries
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Medium) return 4.00m;
                if (Size == ServingSize.Large) return 5.00m;
                return 3.50m;
            }
        }

        /// <summary>
        /// The calories of the fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 365;
                if (Size == ServingSize.Medium) calories = 465;
                if (Size == ServingSize.Large) calories = 510;
                if (Sauce) calories += 80;
                return calories;
            }
        }
    }
}
