using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing Fryceritops french fries
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// The name of the fries
        /// </summary>
        public override string Name { get => $"{Size} Fryceritops"; }

        /// <summary>
        /// Indicates that the fries are salted
        /// </summary>
        private bool _salt = true;

        /// <summary>
        /// Public property for _salt, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Salt
        {
            get => _salt;
            set
            {
                if(_salt != value)
                {
                    _salt = value;
                    AddToSpecialInstructions("Salt", _salt);
                    OnPropertyChanged(nameof(Salt));
                }
            }
        }

        /// <summary>
        /// Indicates that the fries are served with fry sauce
        /// </summary>
        private bool _sauce = false;

        /// <summary>
        /// Public property for _sauce, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Sauce
        {
            get => _sauce;
            set
            {
                if (_sauce != value)
                {
                    _sauce = value;
                    AddToSpecialInstructions("Sauce", _sauce);
                    OnPropertyChanged(nameof(Sauce));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// The price of the fries
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Medium) return 4.00m;
                if (Size == ServingSize.Large) return 5.00m;
                return 3.50m;
            }
        }

        /// <summary>
        /// The calories of the fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 365;
                if (Size == ServingSize.Medium) calories = 465;
                if (Size == ServingSize.Large) calories = 510;
                if (Sauce) calories += 80;
                return calories;
            }
        }
    }
}
