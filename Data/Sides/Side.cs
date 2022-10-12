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
    public abstract class Side : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the Side
        /// </summary>
        public abstract string Name { get; }

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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Size)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Calories)));
                }
            }
        }

        /// <summary>
        /// The price of the Side
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Allows derived Side classes to use the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The name of the property to notify</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
