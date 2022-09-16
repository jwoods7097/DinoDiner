using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing the Deinonychus Double burger
    /// </summary>
    public class DeinonychusDouble : Burger
    {
        /// <summary>
        /// The name of the burger
        /// </summary>
        public override string Name { get => "Deinonychus Double"; }

        public DeinonychusDouble()
        {
            Patties = 2;
            BBQ = true;
            Pickle = true;
            Onion = true;
            Mushrooms = true;
            SwissCheese = true;
        }
    }
}
