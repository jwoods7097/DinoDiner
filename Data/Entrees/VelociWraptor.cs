using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a VelociWraptor caesar chicken wrap
    /// </summary>
    public class VelociWraptor
    {
        /// <summary>
        /// The name of the wrap
        /// </summary>
        public string Name { get; } = "Veloci-Wraptor";

        /// <summary>
        /// The price of the wrap
        /// </summary>
        public decimal Price { get; } = 6.25m;

        /// <summary>
        /// The calories of the wrap
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 732;
                if (!Dressing) calories -= 94;
                if (!Cheese) calories -= 22;
                return calories;
            }
        }

        /// <summary>
        /// Indicates the wrap is served with caesar dressing
        /// </summary>
        public bool Dressing { get; set; } = true;

        /// <summary>
        /// Indicates the wrap is served with parmesan cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
    }
}
