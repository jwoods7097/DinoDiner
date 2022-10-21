using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A class representing the Cretaceous Coffee
    /// </summary>
    public class CretaceousCoffee : Drink
    {
        /// <summary>
        /// The name of the coffee
        /// </summary>
        public override string Name { get => $"{Size} Cretaceous Coffee"; }

        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Medium) return 1.25m;
                if (Size == ServingSize.Large) return 2.00m;
                return 0.75m;
            }
        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Cream) return 64;
                return 0;
            }
        }

        /// <summary>
        /// Indicates the coffee is served with cream
        /// </summary>
        private bool _cream = false;

        /// <summary>
        /// Public property for _cream, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Cream
        {
            get => _cream;
            set
            {
                if(_cream != value)
                {
                    _cream = value;
                    AddToSpecialInstructions("Cream", _cream);
                    OnPropertyChanged(nameof(Cream));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }
    }
}
