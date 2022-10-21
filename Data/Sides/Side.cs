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
    /// A base class for all sides sold at DinoDiner
    /// </summary>
    public abstract class Side : MenuItem
    {
        /// <summary>
        /// The serving size of the Side
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
                if(_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(Size));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }
    }
}
