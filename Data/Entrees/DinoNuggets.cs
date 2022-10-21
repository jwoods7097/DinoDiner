using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing Dino Nuggets chicken nuggets
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// The name of the nuggets
        /// </summary>
        public override string Name { get => $"{Count} Dino Nuggets"; }

        /// <summary>
        /// Indicates how many nuggets are in the entree
        /// </summary>
        private uint _count = 6;

        /// <summary>
        /// Public property for _count, invokes PropertyChanged for necessary properties
        /// </summary>
        public uint Count
        {
            get => _count;
            set
            {
                if(_count != value)
                {
                    _count = value;
                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// The price of the nuggets
        /// </summary>
        public override decimal Price { get => 0.25m * Count; }

        /// <summary>
        /// The calories of the nuggets
        /// </summary>
        public override uint Calories { get => 61 * Count; }
    }
}
