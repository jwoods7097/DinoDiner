using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at DinoDiner
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The name of the Entree
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The price of the Entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }
    }
}
