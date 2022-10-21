using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing the T-Rex Triple burger
    /// </summary>
    public class TRexTriple : Burger
    {
        /// <summary>
        /// The name of the burger
        /// </summary>
        public override string Name { get; } = "T-Rex Triple";
        
        public TRexTriple()
        {
            Patties = 3;
            DefaultPatties = 3;
            Ketchup = true;
            Mayo = true;
            Pickle = true;
            Onion = true;
            Lettuce = true;
            Tomato = true;
            SpecialInstructions.Clear();
        }
    }
}
