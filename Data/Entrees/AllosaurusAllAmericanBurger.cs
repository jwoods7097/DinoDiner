using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing the Allosaurus All-American Burger
    /// </summary>
    public class AllosaurusAllAmericanBurger : Burger
    {
        /// <summary>
        /// The name of the burger
        /// </summary>
        public override string Name { get; } = "Allosaurus All-American Burger";

        public AllosaurusAllAmericanBurger()
        {
            Ketchup = true;
            Mustard = true;
            Pickle = true;
            SpecialInstructions.Clear();
        }
    }
}
