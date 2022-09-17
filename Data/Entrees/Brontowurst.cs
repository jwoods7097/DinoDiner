using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Brontowurst brautwurst
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// The name of the brautwurst
        /// </summary>
        public override string Name { get; } = "Brontowurst";

        /// <summary>
        /// The price of the brautwurst
        /// </summary>
        public override decimal Price { get; } = 5.86m;

        /// <summary>
        /// The calories of the brautwurst
        /// </summary>
        public override uint Calories { get; } = 512;

        /// <summary>
        /// Indicates the brautwurst has onions
        /// </summary>
        public bool Onions { get; set; } = true;

        /// <summary>
        /// Indicates the brautwurst has peppers
        /// </summary>
        public bool Peppers { get; set; } = true;
    }
}
