using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;

namespace DinoDiner.Data
{
    /// <summary>
    /// Represents an Order at Dino Diner
    /// </summary>
    public class Order : ObservableCollection<MenuItem>
    {
        /// <summary>
        /// The sales tax rate as a percentage
        /// </summary>
        public decimal SalesTaxRate { get; set; } = 0.09m;

        /// <summary>
        /// The price of all items in this order
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal sum = 0.00m;
                foreach(MenuItem item in this)
                {
                    sum += item.Price;
                }
                return sum;
            }
        }

        /// <summary>
        /// The tax charged on this order
        /// </summary>
        public decimal Tax { get => Subtotal * SalesTaxRate; }

        /// <summary>
        /// The total price of this order
        /// </summary>
        public decimal Total { get => Subtotal + Tax; }

        /// <summary>
        /// The total calories of all items in this order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint sum = 0u;
                foreach (MenuItem item in this)
                {
                    sum += item.Calories;
                }
                return sum;
            }
        }

        /// <summary>
        /// The next order number, allows order numbers to be unique
        /// </summary>
        private static uint _nextOrderNumber = 1;

        /// <summary>
        /// The order number of this order
        /// </summary>
        public uint Number { get; }

        /// <summary>
        /// The date and time this order was placed
        /// </summary>
        public DateTime PlacedAt { get; }

        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
            PlacedAt = DateTime.Now;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Handles changes made to the order
        /// </summary>
        /// <param name="sender">The object that called this event</param>
        /// <param name="e">Event arguments</param>
        private void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Subtotal)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(MenuItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (MenuItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                default:
                    throw new NotImplementedException("Action not supported!");
            }
        }

        /// <summary>
        /// Handles changes to items in the order
        /// </summary>
        /// <param name="sender">The object that called this event</param>
        /// <param name="e">Event arguments</param>
        private void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Total)));
            }
            else if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));
            }
        }
    }
}
