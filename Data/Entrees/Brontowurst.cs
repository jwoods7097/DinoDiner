using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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
        private bool _onions = true;

        /// <summary>
        /// Public property for _onions, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Onions
        {
            get => _onions;
            set
            {
                if(_onions != value)
                {
                    _onions = value;
                    AddToSpecialInstructions("Onions", _onions);
                    OnPropertyChanged(nameof(Onions));
                }
            }
        }

        /// <summary>
        /// Indicates the brautwurst has peppers
        /// </summary>
        private bool _peppers = true;

        /// <summary>
        /// Public property for _peppers, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Peppers
        {
            get => _peppers;
            set
            {
                if(_peppers != value)
                {
                    _peppers = value;
                    AddToSpecialInstructions("Peppers", _peppers);
                    OnPropertyChanged(nameof(Peppers));
                }
            }
        }
    }
}
