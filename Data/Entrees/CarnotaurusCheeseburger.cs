using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing the Carnotaurus Cheeseburger
    /// </summary>
    public class CarnotaurusCheeseburger : Burger
    {
        /// <summary>
        /// The name of the cheeseburger
        /// </summary>
        public override string Name { get; } = "Carnotaurus Cheeseburger";

        public CarnotaurusCheeseburger()
        {
            Tomato = true;
            Ketchup = true;
            Pickle = true;
            AmericanCheese = true;
            SpecialInstructions.Clear();
        }
    }
}
