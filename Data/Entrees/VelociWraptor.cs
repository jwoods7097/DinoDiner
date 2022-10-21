using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a VelociWraptor caesar chicken wrap
    /// </summary>
    public class VelociWraptor : Entree
    {
        /// <summary>
        /// The name of the wrap
        /// </summary>
        public override string Name { get; } = "Veloci-Wraptor";

        /// <summary>
        /// The price of the wrap
        /// </summary>
        public override decimal Price { get; } = 6.25m;

        /// <summary>
        /// The calories of the wrap
        /// </summary>
        public override uint Calories
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
        private bool _dressing = true;

        /// <summary>
        /// Public property for _dressing, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Dressing
        {
            get => _dressing;
            set
            {
                if(_dressing != value)
                {
                    _dressing = value;
                    AddToSpecialInstructions("Dressing", _dressing);
                    OnPropertyChanged(nameof(Dressing));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the wrap is served with cheese
        /// </summary>
        private bool _cheese = true;

        /// <summary>
        /// Public property for _cheese, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Cheese
        {
            get => _cheese;
            set
            {
                if (_cheese != value)
                {
                    _cheese = value;
                    AddToSpecialInstructions("Cheese", _cheese);
                    OnPropertyChanged(nameof(Cheese));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }
    }
}
