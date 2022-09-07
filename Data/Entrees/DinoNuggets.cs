using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing Dino Nuggets chicken nuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// The name of the nuggets
        /// </summary>
        public string Name { get => $"{Count} Dino Nuggets"; }

        /// <summary>
        /// Indicates how many nuggets are in the entree
        /// </summary>
        public uint Count { get; set; } = 6;

        /// <summary>
        /// The price of the nuggets
        /// </summary>
        public decimal Price { get => 0.25m * Count; }

        /// <summary>
        /// The calories of the nuggets
        /// </summary>
        public uint Calories { get => 61 * Count; }
    }
}
