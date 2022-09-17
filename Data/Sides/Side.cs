using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A base class for all sides sold at DinoDiner
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The name of the Side
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The serving size of the Side
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// The price of the Side
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Side
        /// </summary>
        public abstract uint Calories { get; }
    }
}
