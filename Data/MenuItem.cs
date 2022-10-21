using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Data
{
    /// <summary>
    /// Represents a menu item sold at Dino Diner
    /// </summary>
    public abstract class MenuItem : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the Item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The price of the Item
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Item
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Removals and/or addtions to the Item
        /// </summary>
        public ObservableCollection<string> SpecialInstructions { get; set; } = new ObservableCollection<string>();

        /// <summary>
        /// Adds a modified boolean property to the special instructions for this item
        /// </summary>
        /// <param name="name">The name of the property, as it would be printed</param>
        /// <param name="val">The current value of the property</param>
        protected void AddToSpecialInstructions(string name, bool val)
        {
            string add = $"Add {name}";
            string hold = $"Hold {name}";
            if(val)
            {
                if(SpecialInstructions.Contains(hold))
                {
                    SpecialInstructions.Remove(hold);
                }
                else
                {
                    SpecialInstructions.Add(add);
                }
            }
            else
            {
                if (SpecialInstructions.Contains(add))
                {
                    SpecialInstructions.Remove(add);
                }
                else
                {
                    SpecialInstructions.Add(hold);
                }
            }
        }

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
