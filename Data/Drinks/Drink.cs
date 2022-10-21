using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks sold at Dino Diner
    /// </summary>
    public abstract class Drink : MenuItem
    {
        /// <summary>
        /// The serving size of the Drink
        /// </summary>
        private ServingSize _size;

        /// <summary>
        /// Public property for _size, invokes PropertyChanged for necessary properties
        /// </summary>
        public ServingSize Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(Size));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Price));
                    if(this is Plilosoda)
                    {
                        OnPropertyChanged(nameof(Calories));
                    }
                }
            }
        }
    }
}
