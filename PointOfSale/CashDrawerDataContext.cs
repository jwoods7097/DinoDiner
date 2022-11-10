using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using RoundRegister;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// ViewModel for the CashDrawerControl
    /// </summary>
    public class CashDrawerDataContext : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// How many hundred dollar bills the customer provided
        /// </summary>
        private uint _customerHundreds = 0;

        /// <summary>
        /// Public property for _customerHundreds, notifies the property has been changed
        /// </summary>
        public uint CustomerHundreds
        {
            get => _customerHundreds;
            set
            {
                if(_customerHundreds != value)
                {
                    CashDrawer.Hundreds += value - _customerHundreds;
                    _customerHundreds = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerHundreds)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many fifty dollar bills the customer provided
        /// </summary>
        private uint _customerFifties = 0;

        /// <summary>
        /// Public property for _customerFifties, notifies the property has been changed
        /// </summary>
        public uint CustomerFifties
        {
            get => _customerFifties;
            set
            {
                if (_customerFifties != value)
                {
                    CashDrawer.Fifties += value - _customerFifties;
                    _customerFifties = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerFifties)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many twenty dollar bills the customer provided
        /// </summary>
        private uint _customerTwenties = 0;

        /// <summary>
        /// Public property for _customerHundreds, notifies the property has been changed
        /// </summary>
        public uint CustomerTwenties
        {
            get => _customerTwenties;
            set
            {
                if (_customerTwenties != value)
                {
                    CashDrawer.Twenties += value - _customerTwenties;
                    _customerTwenties = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerTwenties)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many ten dollar bills the customer provided
        /// </summary>
        private uint _customerTens = 0;

        /// <summary>
        /// Public property for _customerTens, notifies the property has been changed
        /// </summary>
        public uint CustomerTens
        {
            get => _customerTens;
            set
            {
                if (_customerTens != value)
                {
                    CashDrawer.Tens += value - _customerTens;
                    _customerTens = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerTens)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many five dollar bills the customer provided
        /// </summary>
        private uint _customerFives = 0;

        /// <summary>
        /// Public property for _customerFives, notifies the property has been changed
        /// </summary>
        public uint CustomerFives
        {
            get => _customerFives;
            set
            {
                if (_customerFives != value)
                {
                    CashDrawer.Fives += value - _customerFives;
                    _customerFives = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerFives)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many two dollar bills the customer provided
        /// </summary>
        private uint _customerTwos = 0;

        /// <summary>
        /// Public property for _customerTwos, notifies the property has been changed
        /// </summary>
        public uint CustomerTwos
        {
            get => _customerTwos;
            set
            {
                if (_customerTwos != value)
                {
                    CashDrawer.Twos += value - _customerTwos;
                    _customerTwos = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerTwos)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many one dollar bills the customer provided
        /// </summary>
        private uint _customerOnes = 0;

        /// <summary>
        /// Public property for _customerOnes, notifies the property has been changed
        /// </summary>
        public uint CustomerOnes
        {
            get => _customerOnes;
            set
            {
                if (_customerOnes != value)
                {
                    CashDrawer.Ones += value - _customerOnes;
                    _customerOnes = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerOnes)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many dollar coins the customer provided
        /// </summary>
        private uint _customerDollars = 0;

        /// <summary>
        /// Public property for _customerDollars, notifies the property has been changed
        /// </summary>
        public uint CustomerDollars
        {
            get => _customerDollars;
            set
            {
                if (_customerDollars != value)
                {
                    CashDrawer.DollarCoins += value - _customerDollars;
                    _customerDollars = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerDollars)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many half dollar coins the customer provided
        /// </summary>
        private uint _customerHalfDollars = 0;

        /// <summary>
        /// Public property for _customerDollars, notifies the property has been changed
        /// </summary>
        public uint CustomerHalfDollars
        {
            get => _customerHalfDollars;
            set
            {
                if (_customerHalfDollars != value)
                {
                    CashDrawer.HalfDollarCoins += value - _customerHalfDollars;
                    _customerHalfDollars = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerHalfDollars)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many quarters the customer provided
        /// </summary>
        private uint _customerQuarters = 0;

        /// <summary>
        /// Public property for _customerQuarters, notifies the property has been changed
        /// </summary>
        public uint CustomerQuarters
        {
            get => _customerQuarters;
            set
            {
                if (_customerQuarters != value)
                {
                    CashDrawer.Quarters += value - _customerQuarters;
                    _customerQuarters = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerQuarters)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many dimes the customer provided
        /// </summary>
        private uint _customerDimes = 0;

        /// <summary>
        /// Public property for _customerDimes, notifies the property has been changed
        /// </summary>
        public uint CustomerDimes
        {
            get => _customerDimes;
            set
            {
                if (_customerDimes != value)
                {
                    CashDrawer.Dimes += value - _customerDimes;
                    _customerDimes = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerDimes)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many nickels the customer provided
        /// </summary>
        private uint _customerNickels = 0;

        /// <summary>
        /// Public property for _customerNickels, notifies the property has been changed
        /// </summary>
        public uint CustomerNickels
        {
            get => _customerNickels;
            set
            {
                if (_customerNickels != value)
                {
                    CashDrawer.Nickles += value - _customerNickels;
                    _customerNickels = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerNickels)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How many pennies the customer provided
        /// </summary>
        private uint _customerPennies = 0;

        /// <summary>
        /// Public property for _customerPennies, notifies the property has been changed
        /// </summary>
        public uint CustomerPennies
        {
            get => _customerPennies;
            set
            {
                if (_customerPennies != value)
                {
                    CashDrawer.Pennies += value - _customerPennies;
                    _customerPennies = value;
                    CalculateChange();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerPennies)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// How much the customer has paid
        /// </summary>
        private decimal CustomerPaid
        {
            get => 100m * CustomerHundreds + 50m * CustomerFifties + 20m * CustomerTwenties + 10m * CustomerTens + 5m * CustomerFives + 2m * CustomerTwos + 1m * CustomerOnes
                + 1m * CustomerDollars + 0.50m * CustomerHalfDollars + 0.25m * CustomerQuarters + 0.10m * CustomerDimes + 0.05m * CustomerNickels + 0.01m * CustomerPennies;
        }

        /// <summary>
        /// How many hundred dollar bills to give back in change
        /// </summary>
        private uint _changeHundreds = 0;

        /// <summary>
        /// Public property for _changeHundreds, notifies the property has been changed
        /// </summary>
        public uint ChangeHundreds
        {
            get => _changeHundreds;
            set
            {
                if (_changeHundreds != value)
                {
                    _changeHundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeHundreds)));
                }
            }
        }

        /// <summary>
        /// How many fifty dollar bills to give back in change
        /// </summary>
        private uint _changeFifties = 0;

        /// <summary>
        /// Public property for _changeFifties, notifies the property has been changed
        /// </summary>
        public uint ChangeFifties
        {
            get => _changeFifties;
            set
            {
                if (_changeFifties != value)
                {
                    _changeFifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeFifties)));
                }
            }
        }

        /// <summary>
        /// How many twenty dollar bills to give back in change
        /// </summary>
        private uint _changeTwenties = 0;

        /// <summary>
        /// Public property for _changeHundreds, notifies the property has been changed
        /// </summary>
        public uint ChangeTwenties
        {
            get => _changeTwenties;
            set
            {
                if (_changeTwenties != value)
                {
                    _changeTwenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeTwenties)));
                }
            }
        }

        /// <summary>
        /// How many ten dollar bills to give back in change
        /// </summary>
        private uint _changeTens = 0;

        /// <summary>
        /// Public property for _changeTens, notifies the property has been changed
        /// </summary>
        public uint ChangeTens
        {
            get => _changeTens;
            set
            {
                if (_changeTens != value)
                {
                    _changeTens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeTens)));
                }
            }
        }

        /// <summary>
        /// How many five dollar bills to give back in change
        /// </summary>
        private uint _changeFives = 0;

        /// <summary>
        /// Public property for _changeFives, notifies the property has been changed
        /// </summary>
        public uint ChangeFives
        {
            get => _changeFives;
            set
            {
                if (_changeFives != value)
                {
                    _changeFives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeFives)));
                }
            }
        }

        /// <summary>
        /// How many two dollar bills to give back in change
        /// </summary>
        private uint _changeTwos = 0;

        /// <summary>
        /// Public property for _changeTwos, notifies the property has been changed
        /// </summary>
        public uint ChangeTwos
        {
            get => _changeTwos;
            set
            {
                if (_changeTwos != value)
                {
                    _changeTwos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeTwos)));
                }
            }
        }

        /// <summary>
        /// How many one dollar bills to give back in change
        /// </summary>
        private uint _changeOnes = 0;

        /// <summary>
        /// Public property for _changeOnes, notifies the property has been changed
        /// </summary>
        public uint ChangeOnes
        {
            get => _changeOnes;
            set
            {
                if (_changeOnes != value)
                {
                    _changeOnes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOnes)));
                }
            }
        }

        /// <summary>
        /// How many dollar coins to give back in change
        /// </summary>
        private uint _changeDollars = 0;

        /// <summary>
        /// Public property for _changeDollars, notifies the property has been changed
        /// </summary>
        public uint ChangeDollars
        {
            get => _changeDollars;
            set
            {
                if (_changeDollars != value)
                {
                    _changeDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDollars)));
                }
            }
        }

        /// <summary>
        /// How many half dollar coins to give back in change
        /// </summary>
        private uint _changeHalfDollars = 0;

        /// <summary>
        /// Public property for _changeDollars, notifies the property has been changed
        /// </summary>
        public uint ChangeHalfDollars
        {
            get => _changeHalfDollars;
            set
            {
                if (_changeHalfDollars != value)
                {
                    _changeHalfDollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeHalfDollars)));
                }
            }
        }

        /// <summary>
        /// How many quarters to give back in change
        /// </summary>
        private uint _changeQuarters = 0;

        /// <summary>
        /// Public property for _changeQuarters, notifies the property has been changed
        /// </summary>
        public uint ChangeQuarters
        {
            get => _changeQuarters;
            set
            {
                if (_changeQuarters != value)
                {
                    _changeQuarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeQuarters)));
                }
            }
        }

        /// <summary>
        /// How many dimes to give back in change
        /// </summary>
        private uint _changeDimes = 0;

        /// <summary>
        /// Public property for _changeDimes, notifies the property has been changed
        /// </summary>
        public uint ChangeDimes
        {
            get => _changeDimes;
            set
            {
                if (_changeDimes != value)
                {
                    _changeDimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDimes)));
                }
            }
        }

        /// <summary>
        /// How many nickels to give back in change
        /// </summary>
        private uint _changeNickels = 0;

        /// <summary>
        /// Public property for _changeNickels, notifies the property has been changed
        /// </summary>
        public uint ChangeNickels
        {
            get => _changeNickels;
            set
            {
                if (_changeNickels != value)
                {
                    _changeNickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeNickels)));
                }
            }
        }

        /// <summary>
        /// How many pennies to give back in change
        /// </summary>
        private uint _changePennies = 0;

        /// <summary>
        /// Public property for _changePennies, notifies the property has been changed
        /// </summary>
        public uint ChangePennies
        {
            get => _changePennies;
            set
            {
                if (_changePennies != value)
                {
                    _changePennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangePennies)));
                }
            }
        }

        /// <summary>
        /// Total cost of the order
        /// </summary>
        private decimal _total = 0;

        /// <summary>
        /// Public property for _total, notifies the property has been changed
        /// </summary>
        public decimal Total
        {
            get => _total;
            set
            {
                if(_total != value)
                {
                    _total = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Total)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeOwed)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullyPaid)));
                }
            }
        }

        /// <summary>
        /// The remaining amount the customer must pay
        /// </summary>
        public decimal AmountDue
        {
            get => Math.Max(0m, Total - CustomerPaid);
        }

        /// <summary>
        /// The change to give back to the customer
        /// </summary>
        public decimal ChangeOwed
        {
            get => Math.Max(0m, CustomerPaid - Total);
        }

        /// <summary>
        /// Indicates the order has been fully paid off and the sale can be completed
        /// </summary>
        public bool FullyPaid
        {
            get => AmountDue == 0m;
        }

        /// <summary>
        /// Calculates the change for each type of currency
        /// </summary>
        private void CalculateChange()
        {
            decimal change = ChangeOwed;
            ChangeHundreds = Math.Min(CashDrawer.Hundreds, (uint)(change / 100m));
            change -= ChangeHundreds * 100m;
            ChangeFifties = Math.Min(CashDrawer.Fifties, (uint)(change / 50m));
            change -= ChangeFifties * 50m;
            ChangeTwenties = Math.Min(CashDrawer.Twenties, (uint)(change / 20m));
            change -= ChangeTwenties * 20m;
            ChangeTens = Math.Min(CashDrawer.Tens, (uint)(change / 10m));
            change -= ChangeTens * 10m;
            ChangeFives = Math.Min(CashDrawer.Fives, (uint)(change / 5m));
            change -= ChangeFives * 5m;
            ChangeTwos = Math.Min(CashDrawer.Twos, (uint)(change / 2m));
            change -= ChangeTwos * 2m;
            ChangeOnes = Math.Min(CashDrawer.Ones, (uint)(change / 1m));
            change -= ChangeOnes * 1m;
            ChangeDollars = Math.Min(CashDrawer.DollarCoins, (uint)(change / 1m));
            change -= ChangeDollars * 1m;
            ChangeHalfDollars = Math.Min(CashDrawer.HalfDollarCoins, (uint)(change / 0.50m));
            change -= ChangeHalfDollars * 0.50m;
            ChangeQuarters = Math.Min(CashDrawer.Quarters, (uint)(change / 0.25m));
            change -= ChangeQuarters * 0.25m;
            ChangeDimes = Math.Min(CashDrawer.Dimes, (uint)(change / 0.10m));
            change -= ChangeDimes * 0.10m;
            ChangeNickels = Math.Min(CashDrawer.Nickles, (uint)(change / 0.05m));
            change -= ChangeNickels * 0.05m;
            ChangePennies = Math.Min(CashDrawer.Pennies, (uint)(change / 0.01m));
        }
    }
}
