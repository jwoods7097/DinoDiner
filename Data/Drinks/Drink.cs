using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks sold at Dino Diner
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The name of the Drink
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The serving size of the Drink
        /// </summary>
        public abstract ServingSize Size { get; set; }

        /// <summary>
        /// The price of the Drink
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Drink
        /// </summary>
        public abstract uint Calories { get; }
    }
}
